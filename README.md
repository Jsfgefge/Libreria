# Libreria
Proyecto Libreria
------------------------------------------------------

En la ventana LogIn es para inicio de sesion, carnet solo acepta numeros y contraseña cualquier caracter. Deje preparados unos registros en el archivo .sql adjunto.
-------------------------------------------------------

La ventana menu es para moverse a traves del programa, dependiendo de cual sea el rango de la persona que ingreso va a dejar acceder a algunos menus o no.

Si es admin (rango 1) va a poder entrar a todo
Si es bibliotecario (rango 2) solo podra acceder a consultas y prestamos
Si es profesor o alumno(rango 3 o 4) va a poder entrar solamente a consultas.

La intencion de tener separado a profesores y alumnos originalmente era para que el profesor no tuviera multa por insolvencia, pero por problemas de tiempo ya no implemente esa parte.
-------------------------------------------------------

En ingreso de libros podremos ingresar titulo del libro, su autor, idioma y, si el libro esta dañado, un comentario acerca de su integridad.
-------------------------------------------------------

En la ventana Prestamos podremos ingresar el carnet de la persona que quiere prestar un libro y al darle al boton Buscar se verificara si la persona esta solvente o si ya ha hecho algun prestamo, en caso que este solvente y no haya realizado ningun prestamo se habilitara el boton "Seguir" para finalizar con el prestamo, en caso contrario nos saldra un mensaje diciendo que primero tiene que estar solvente o que tiene que devolver el libro
-------------------------------------------------------

En finalizacion de prestamo nos cargara automaticamente el carnet de la persona que quiere prestar un libro, luego el bibliotecario o admin ingresara el Id del libro que la persona quiere prestar y le dara a buscar y verificara si el libro esta disponible, en caso de estar disponible se habilitara el boton Prestar y al darle click se finalizara el prestamo y el prestamo se ira al historial de prestamos en la tabla Prestamos, se actualizara el estado del libro a No disponible y se actualizara el estado de prestamo de la persona que presto el libro indicando que ya tiene un prestamo.
-------------------------------------------------------

En este programa faltaron algunas cosas que ya no implemente por cuestiones de tiempo, algunas de esas fueron:
-Manejo de algunas excepciones, como el caso de que pasaba si se ingresaban letras donde deberian de ir numeros
-Implementar calculo de la multa por insolvencia
-Registro de usuarios desde el programa 
-Implentacion de sistema para devolucion de libros
-Mensaje en caso de que en consultas no este el libro buscado, o similaridades con los datos ingresados
