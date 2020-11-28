Kevin Romero         1047519

José De León           1072619

---

### Objetivos

- Aplicar los conocimientos adquiridos a lo largo del curso de Estructuras de Datos II.

---

### Contenido

- Aplicación web tipo MVC implementada para un chat
- Aplicación web tipo API conectada a una base de datos no relacional
- Aplicación de consola para pruebas de funcionalidad

---

### MENSAJES RELEVANTES S. A.

Cumpliendo con las funcionalidades solicitadas por la empresa se desarrolló la siguiente aplicación web.

La aplicación consiste en una plataforma capaz de recibir archivos  y mensajes que se actualiza con la ayuda de un botón para revisar los nuevos mensajes o archivos recibidos, para cumplir con los estándares de seguridad para mensajes relevantes se implemento una encriptación de punto a punto entre cada par de usuarios.

Los archivos para manejar reducir el espacio en el servidor se almacenaron los archivos comprimidos con el algoritmo de LZW.

La plataforma soporta varios usuario conectados y cuenta con una autenticación de credenciales para cada usuario, la privacidad de los usuarios se protege con con el algoritmo de encriptación de SDES.

El manejo de la información se ejecuta en MongoDB, esta se comunica con la plataforma web por medio de un api, que maneja el flujo de datos de dicha plataforma. Para globalizar el acceso de a los usuarios de mensajes relevantes se utiliza un túnel para publicar la aplicación en internet.
