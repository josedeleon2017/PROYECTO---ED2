using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CHAT___Algorithms
{
    public class SDES
    {
        public BitArray Key1 { get; set; }
        public BitArray Key2 { get; set; }

        public string[,] SwapBox1 = new string[4, 4] { { "00", "01", "10", "11" },
                                                       { "10", "00", "01", "11" },
                                                       { "11", "00", "01", "00" },
                                                       { "10", "01", "00", "11" } };

        public string[,] SwapBox0 = new string[4, 4] { { "01", "00", "11", "10" },
                                                       { "11", "10", "01", "00" },
                                                       { "00", "10", "01", "11" },
                                                       { "11", "01", "11", "10" } };
        public byte[] EncryptText(byte[] content)
        {
            List<byte> text = new List<byte>(content.Length);
            for (int i = 0; i < content.Length; i++)
            {
                byte current_byte = EncryptByte(content[i]);
                text.Add(current_byte);
            }
            return text.ToArray();
        }
        public byte[] DecryptText(byte[] content)
        {
            List<byte> text = new List<byte>(content.Length);
            for (int i = 0; i < content.Length; i++)
            {
                byte current_byte = DecryptByte(content[i]);
                text.Add(current_byte);
            }
            return text.ToArray();
        }

        public byte DecryptByte(byte character)
        {
            BitArray initial_permutation = ConvertToBits(character);
            initial_permutation = InitialPermutation(initial_permutation);

            BitArray splited_result1 = CopyTo(initial_permutation, 0, 4);
            BitArray splited_result2 = CopyTo(initial_permutation, 4, 4);


            BitArray expand_result = ExpandAndPermute(splited_result2);
            expand_result = expand_result.Xor(Key2);


            BitArray input_sw0 = CopyTo(expand_result, 0, 4);
            BitArray input_sw1 = CopyTo(expand_result, 4, 4);

            BitArray sw_result = Concat(GetSwapBox0(input_sw0), GetSwapBox1(input_sw1));
            sw_result = Permutation4(sw_result);

            sw_result = sw_result.Xor(splited_result1);

            BitArray swap_result = Concat(splited_result2, sw_result);

            BitArray ep_swap_result = CopyTo(swap_result, 4, 4);
            ep_swap_result = ExpandAndPermute(ep_swap_result);
            ep_swap_result = ep_swap_result.Xor(Key1);


            input_sw0 = CopyTo(ep_swap_result, 0, 4);
            input_sw1 = CopyTo(ep_swap_result, 4, 4);
            BitArray input_p4 = Concat(GetSwapBox0(input_sw0), GetSwapBox1(input_sw1));
            input_p4 = Permutation4(input_p4);

            BitArray input_inverseIP = input_p4.Xor(splited_result2);
            input_inverseIP = Concat(input_inverseIP, sw_result);

            BitArray result = InverseInitialPermutation(input_inverseIP);

            return ConvertToByte(result);
        }

        public void SetKeys(BitArray key)
        {
            key = Permutation10(key);

            BitArray splited_key1 = CopyTo(key, 0, 5);
            BitArray splited_key2 = CopyTo(key, 5, 5);

            splited_key1 = LeftShift1(splited_key1);
            splited_key2 = LeftShift1(splited_key2);
            BitArray complete_key1 = Concat(splited_key1, splited_key2);

            //SET KEY 1
            Key1 = Permutation8(complete_key1);

            splited_key1 = LeftShift2(splited_key1);
            splited_key2 = LeftShift2(splited_key2);
            BitArray complete_key2 = Concat(splited_key1, splited_key2);

            //SET KEY 2
            Key2 = Permutation8(complete_key2);
        }
        public byte EncryptByte(byte character)
        {
            //ROUND 1 //////////////////////////////////////////////////
            BitArray character_byte = ConvertToBits(character);
            BitArray result_IP = InitialPermutation(character_byte);

            BitArray splited_result1 = CopyTo(result_IP, 0, 4);

            //
            BitArray splited_result2 = CopyTo(result_IP, 4, 4);
            BitArray expand_result2 = ExpandAndPermute(splited_result2);

            BitArray xor_result1 = expand_result2.Xor(Key1);

            //divide and insert on each swapbox ->
            BitArray input_swbox0 = CopyTo(xor_result1, 0, 4);
            BitArray input_swbox1 = CopyTo(xor_result1, 4, 4);


            //swapbox
            BitArray result_swbox0 = GetSwapBox0(input_swbox0);
            BitArray result_swbox1 = GetSwapBox1(input_swbox1);
            //
            BitArray input_swbox = Concat(result_swbox0, result_swbox1);
            input_swbox = Permutation4(input_swbox);
            input_swbox = input_swbox.Xor(splited_result1);
            //////////////////////////////////////////////////////////


            //swap result
            BitArray swap_complete = Concat(splited_result2, input_swbox);

            //ROUND 2 ///////////////////////////////////////////////
            BitArray splited_swap1 = CopyTo(swap_complete, 0, 4);
            BitArray splited_swap2 = CopyTo(swap_complete, 4, 4);

            BitArray expand_splited_swap2 = ExpandAndPermute(splited_swap2);
            BitArray xor_result2 = expand_splited_swap2.Xor(Key2);

            // divide and insert on each swapbox->
            input_swbox0 = CopyTo(xor_result2, 0, 4);
            input_swbox1 = CopyTo(xor_result2, 4, 4);


            //swapbox
            result_swbox0 = GetSwapBox0(input_swbox0);
            result_swbox1 = GetSwapBox1(input_swbox1);
            //
            input_swbox = Concat(result_swbox0, result_swbox1);
            input_swbox = Permutation4(input_swbox);

            BitArray input_inverseIP = input_swbox.Xor(splited_swap1);
            input_inverseIP = Concat(input_inverseIP, splited_swap2);

            BitArray result = InverseInitialPermutation(input_inverseIP);

            return ConvertToByte(result);
        }
        public BitArray Permutation10(BitArray input)
        {
            BitArray output = new BitArray(10);
            output[0] = input[4];
            output[1] = input[5];
            output[2] = input[2];
            output[3] = input[0];
            output[4] = input[8];
            output[5] = input[9];
            output[6] = input[1];
            output[7] = input[3];
            output[8] = input[7];
            output[9] = input[6];

            return output;
        }
        public BitArray Permutation8(BitArray input)
        {
            BitArray output = new BitArray(8);
            output[0] = input[2];
            output[1] = input[4];
            output[2] = input[6];
            output[3] = input[9];
            output[4] = input[0];
            output[5] = input[5];
            output[6] = input[7];
            output[7] = input[1];

            return output;
        }
        public BitArray Permutation4(BitArray input)
        {
            BitArray output = new BitArray(4);
            output[0] = input[2];
            output[1] = input[0];
            output[2] = input[3];
            output[3] = input[1];

            return output;
        }
        public BitArray LeftShift1(BitArray input)
        {
            BitArray output = new BitArray(input.Length);

            output[output.Length - 1] = input[0];
            for (int i = 0; i < output.Length - 1; i++)
            {
                output[i] = input[i + 1];
            }
            return output;
        }
        public BitArray LeftShift2(BitArray input)
        {
            BitArray output = new BitArray(input.Length);

            output[output.Length - 2] = input[0];
            output[output.Length - 1] = input[1];
            for (int i = 0; i < output.Length - 2; i++)
            {
                output[i] = input[i + 2];
            }
            return output;
        }
        public BitArray CopyTo(BitArray input, int index, int lenght)
        {
            BitArray output = new BitArray(lenght);

            for (int i = 0; i < lenght; i++)
            {
                output[i] = input[i + index];
            }
            return output;
        }
        public BitArray Concat(BitArray array1, BitArray array2)
        {
            BitArray output = new BitArray(array1.Length + array2.Length);
            for (int i = 0; i < array1.Length; i++)
            {
                output[i] = array1[i];
            }
            for (int i = 0; i < array2.Length; i++)
            {
                output[i + array1.Length] = array2[i];
            }
            return output;
        }
        public BitArray InitialPermutation(BitArray input)
        {
            BitArray output = new BitArray(8);
            output[0] = input[3];
            output[1] = input[0];
            output[2] = input[4];
            output[3] = input[1];
            output[4] = input[6];
            output[5] = input[5];
            output[6] = input[2];
            output[7] = input[7];

            return output;
        }
        public BitArray ExpandAndPermute(BitArray input)
        {
            BitArray output = new BitArray(8);
            output[0] = input[1];
            output[1] = input[3];
            output[2] = input[0];
            output[3] = input[2];
            output[4] = input[3];
            output[5] = input[0];
            output[6] = input[2];
            output[7] = input[1];

            return output;
        }
        public BitArray ConvertToBits(byte value)
        {
            BitArray bits = new BitArray(8);
            string character = Convert.ToString(value, 2).PadLeft(8, '0');
            for (int i = 0; i < bits.Length; i++)
            {
                if (character[i] == '1')
                {
                    bits[i] = true;
                }
                else
                {
                    bits[i] = false;
                }
            }
            return bits;
        }
        public string ConvertToString(BitArray input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == true)
                {
                    result += "1";
                }
                else
                {
                    result += "0";
                }
            }
            return result;
        }
        public byte ConvertToByte(BitArray input)
        {
            string number = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i])
                {
                    number += "1";
                }
                else
                {
                    number += "0";
                }
            }
            byte result = Convert.ToByte(Convert.ToInt32(number, 2));
            return result;
        }
        public BitArray GetSwapBox0(BitArray input)
        {
            BitArray first_bits = new BitArray(2);
            first_bits[0] = input[0];
            first_bits[1] = input[3];

            BitArray second_bits = new BitArray(2);
            second_bits[0] = input[1];
            second_bits[1] = input[2];

            string row = ConvertToString(first_bits);
            string column = ConvertToString(second_bits);

            int row_position = Convert.ToInt32(row, 2);
            int column_position = Convert.ToInt32(column, 2);
            string swpbox_result = SwapBox0[row_position, column_position];

            BitArray result_swpbox = new BitArray(2);
            for (int i = 0; i < swpbox_result.Length; i++)
            {
                if (swpbox_result[i] == '1')
                {
                    result_swpbox[i] = true;
                }
                else
                {
                    result_swpbox[i] = false;
                }
            }
            return result_swpbox;
        }
        public BitArray GetSwapBox1(BitArray input)
        {
            BitArray first_bits = new BitArray(2);
            first_bits[0] = input[0];
            first_bits[1] = input[3];

            BitArray second_bits = new BitArray(2);
            second_bits[0] = input[1];
            second_bits[1] = input[2];

            string row = ConvertToString(first_bits);
            string column = ConvertToString(second_bits);

            int row_position = Convert.ToInt32(row, 2);
            int column_position = Convert.ToInt32(column, 2);
            string swpbox_result = SwapBox1[row_position, column_position];

            BitArray result_swpbox = new BitArray(2);
            for (int i = 0; i < swpbox_result.Length; i++)
            {
                if (swpbox_result[i] == '1')
                {
                    result_swpbox[i] = true;
                }
                else
                {
                    result_swpbox[i] = false;
                }
            }
            return result_swpbox;
        }
        public BitArray InverseInitialPermutation(BitArray input)
        {
            BitArray output = new BitArray(8);
            output[0] = input[1];
            output[1] = input[3];
            output[2] = input[6];
            output[3] = input[0];
            output[4] = input[2];
            output[5] = input[5];
            output[6] = input[4];
            output[7] = input[7];

            return output;
        }
    }
}
