Ejercicios prácticos 3:

1. Añadir un campo de velocidad y salida a la consola:

Se crea un script SpeedController que permite cambiar la velocidad de un cubo utilizando las teclas de flecha arriba-abajo e izquierda-derecha. La velocidad se multiplica por los valores de los ejes vertical y horizontal y el resultado se emite a la consola indicando la tecla pulsada.

2. Asignación de la tecla H a una función de disparo:

Se crea un script TriggerController que llama a la función trigger cuando se pulsa la tecla H.

3. Script para pasar el vector de dirección de movimiento:

Se crea un script MovementController que pasa el vector de dirección de movimiento a un moveDirection proporcional con la posibilidad de ajustarlo en el inspector. La velocidad también es configurable en el inspector.

4. Mover un cubo y una esfera usando teclas:

Creado un script MoveObjects que permite mover un cubo usando las teclas de dirección y una esfera usando las teclas WSAD.

5. Adaptar el movimiento al tiempo de fotograma:

Se adaptó el script MoveWithDeltaTime para tener en cuenta el tiempo de fotograma utilizando Time.deltaTime.

6. Mover el cubo hacia la esfera:

Se creó un script MoveTowardsSphere que permite al cubo moverse hacia la esfera, dado que el cubo no cambia su altura.

7. Rotar el cubo hacia la esfera:

Se creó un script RotateTowardsSphere que permite que el cubo rote de forma que siempre esté de cara a la esfera.

8. Rotar la lente hacia delante:

Creado un script RotateLens que gira la lente hacia delante.

9. 9. Detección de colisión y salida de mensajes:

Creado un script CollisionDetection que emite un mensaje a la consola cuando un objeto colisiona con otro objeto.

10. Configurar un cubo como objeto cinemático y una esfera como objeto físico:

Se ha creado un script KinematicAndPhysical que configura un cubo como objeto cinemático y una esfera como objeto físico.

11.Configuración del cilindro como objeto de tipo Trigger:

Creado un script TriggerObject que configura el cilindro como objeto de tipo Trigger y muestra un mensaje en la consola cuando se produce una colisión.

12. Movimiento del cilindro hacia la esfera:

Para esta parte de la tarea, se creó un script CylinderControl para controlar el movimiento del cilindro en la escena utilizando las teclas WASD. El objetivo era dirigir el cilindro hacia la esfera, para explorar diferentes configuraciones de la esfera y el cilindro, como diferentes masas y modos de cuerpo físico.

Personalización del cilindro:
Un cilindro de un color diferente se añadió a la escena utilizando el Editor de Unity. Para este cilindro, se añadió un componente Rigidbody para convertirlo en un objeto físico.

Control del cilindro:
El script CylinderControl implementó la lógica para controlar el cilindro usando las teclas WASD. Esto permitía mover el cilindro por la escena.

Dirigir el cilindro hacia la esfera:
Para dirigir el cilindro hacia la esfera, se calculaba un vector que conectaba las posiciones del cilindro y la esfera. A continuación, se aplicó una fuerza utilizando el método Rigidbody.AddForce() para mover el cilindro hacia la esfera.

Se investigaron diferentes configuraciones:

La masa de la esfera es 10 veces la del cilindro: En esta configuración, el cilindro se movía lentamente hacia la esfera debido a la gran masa de la esfera.
La masa de la esfera es 10 veces menor que la del cilindro: En esta configuración, el cilindro se movía hacia la esfera más rápidamente debido a la menor masa de la esfera.
Esfera en modo Cinemático: En este caso, el cilindro podía interactuar con la esfera, pero la esfera no reaccionaba a las colisiones porque estaba en modo Cinemático.
Esfera en modo Trigger: Cuando la esfera estaba configurada como Trigger, las colisiones con ella no provocaban reacciones físicas y el cilindro la atravesaba.
Explicación de los resultados:

La masa de los objetos afecta a su movimiento y a la interacción entre ellos. Una mayor masa de una esfera ralentiza el movimiento del cilindro hacia ella, mientras que una masa menor lo acelera.
El modo Cinemático de un objeto lo hace inmóvil e inmune a las colisiones con otros objetos.
El modo Trigger hace que el objeto sea inmune a las colisiones, pero permite que se activen eventos OnTriggerEnter cuando entra en su zona.
Experimentar con diferentes configuraciones de objetos nos ayudó a entender cómo los parámetros físicos y los modos afectan a su interacción en una escena Unity.

Todos los scripts fueron creados y configurados en el entorno Unity, y los objetos fueron configurados como se especifica en las asignaciones. El informe incluye una descripción de cada script y su finalidad.