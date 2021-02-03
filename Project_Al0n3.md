# Project_Al0n3 acto 1

Project_Al0n3 es un juego de terror psicológico, la idea detrás de este es mantenerse corto pero intentar dejar una idea de vacío en tanto el jugador como algún posible espectador.

## Cosas a tomar en cuenta

+ El juego toma el suicidio del personaje principal como punto detonante.
+ Esto lleva a un estado del protagonista de "sueño pre-mortem".
+ Una de las ideas principales es solo despertar en el living de la casa del protagonista sin saber nada.
+ ***El protagonista no habla a cámara, todo lo que sabemos o la mayoría debe venir de texto y ruidos exteriores.***
+ El camino del protagonista debe terminar apagando la televisión representando este el cese de su vida.
+ Lo que parece una despedida tierna y hasta poética, se transforma en el purgatorio, un lugar obscuro sin alma alguna pero algo te ve y no sabes que.
+ En la cercanía entre un tipo de niebla extraña se distinguen caras siniestras y risas constantes (Idea en proceso).

---

## Punto Técnico

En esta parte de la documentación voy a hacer énfasis de problemas técnicos tanto como de consejos tomando en cuenta el carácter técnico del proyecto, iniciando por un tema muy importante

+ Error de el maldito material que no se carga al prender la luz (este error se genera no se por que pero aveces el material no carga "específicamente el color de el emission") **Arreglado, aparentemente...**
  + esto se repara habilitando tanto el material y la luz en el editor, al iniciar el juego apagamos las luces y salimos del "juego" luego de esto desactivamos las luces y por alguna razón ahí se repara el error.
  + cabe resaltar que no se si es una forma oficial de arreglarlo pero me ha funcionado :b.
---

## Peticiones de diseño

+ en la pared "específicamente en la que añadiré la pintura del payaso" al iniciarse el acto 2 dependiendo del final (finales malos: esta se llena de imágenes con una cara sonriendo con fondo negro y en esta animada caras reales pero en partes pequeñas que cambian muy rápido, a excepción que en este caso serán muchísimas) (finales buenos: en este se puede observar una fuerte luz proveniente de la puerta principal de la casa, la imagen de payaso se ve en una pared, y al acercarte se apaga la luz, todo esta en negro y las caras cambian a la misma vara tenebrosa con animación en todas partes, se van añadiendo de a poco y luego al estar todo lleno con un crescendo de violín el juego se cierra.)

  ---

+ **El teléfono (referencia a "the stanley parable")**

  Al seleccionar uno de los finales se ve una pared con un teléfono siendo alumbrado por una lampara de techo.

  ---

+ **La puerta de los gritos**

  > Al llegar al lugar veo una puerta de madera barnizada, de ella salen gritos constantes, como si la habitación estuviera llena de gente sufriendo y deseando encontrarse con la muerte.
  >
  > Al abrirla los gritos paran y solo me encuentro con una pequeña habitación vacía, un sentimiento raro se apodera de mi mientras me adentro a la misma.
  >
  > Llegando al final de la misma siento que la puerta se cierra bruscamente y desde el otro lado de la puerta se escuchan gritos mas fuertes aun.
  >
  > **Como si la habitación en la que estaba se llenara de gente gritando y deseando morir**.
  >
  > Al abrir la puerta nuevamente los gritos cesan, espero no unirme a la gente tras esa puerta.


---

## Orden cronológico

1. El protagonista despierta en el sillón de la sala.
2. El protagonista escucha algo caer desde el baño al final de un pasillo (interactuar con esta no hace nada aun ).
3. Ves entre el living y la cocina descubres la llave para entrar a la habitación.
4. Ideal ir mostrando constantemente mensajes que demuestren la destrucción interna del protagonista, que representen que este necesitaba ayuda y alguien se la intentaba dar.
5. Al entrar a la habitación se ven mas cosas de investigar y el pasillo se extiende, se hace mas obscuro y cuesta mas ver el final del mismo
6. Al mismo tiempo alguien grita del baño "Déjenme salir!!!! Ayuda por favor!!! Me arrepiento, Quiero salir, Quiero llegar al final.!!!" mientras deliberadamente intenta abrir la cerradura con llave, esta no se abre y los sonidos se hacen mas fuertes mientras vas llegando a la sala principal.
7. El final cambia según las decisiones del jugador.
11. El juego se cierra.
    + Dato técnico (al cerrarse se crea una variable que se guarde al cerrar el juego, esta debe hacer que la pantalla principal cambie por una mas "rara"

---

## Planificación

**acto 1** 

Antes que nada unas palabras sinceras, estoy iniciando este texto el día 24 de septiembre a las 1:50 (día 2 de trabajo) ***Nota del desarrollador: no trabajar a esta hora en temas existenciales ni en las partes que deben dar miedo :,D***

El jugador se levanta de la nada en el sillón de la sala, la obscuridad lo consume, pareciera que incluso algo lo ve desde las sombras, pero en realidad no hay nada vea donde vea... solo una sala con pocos muebles, desordenada y ese aterrador vacío... al menos eso creo.

El baño, la salida, una habitación y la cocina son las únicas puertas que se aprecian desde esta sala.

+ El baño se muestra cerrado, bloqueado desde dentro y no aparentas tener una llave **al menos por ahora**. 

  Un sonido fuerte  suena en el baño se escuchan murmullos desde dentro y en la cocina lo único que se distingue es la entrada.

  ---

+ La salida no presenta una forma de abrirse, la cerradura esta bloqueada y solo se aprecia un espacio por debajo por donde podría entrar algún papel o periódico.

  ---

+ La habitación parece ser accesible, pero sientes como si alguien la bloqueara desde el otro lado.

  ---

+ La cocina esta abierta, tu única limitación de entrar a ella es que esta cubierta de una obscuridad que te ahoga en miedo el verla, de hecho no podrías decir que es una cocina sin prender la luz.

  La cocina aun con la luz prendida se ve obscura, el jugador al entrar en ella ve varias cosas de interés, desde post-its en tanto el refrigerador como en una pared en su lado obscuro como variedad de platos sucios entre otras cosas (al acercarte a el post-it en la parte obscura suena un violín de aspecto terrorífico en un crescendo que termina en una forma fría pero haciendo una transformación drástica hacia una música que sale del refrigerador)

---

**En la mesa del living hay un celular, al interactuar con el hay 3 opciones:**

1. dejar de imagen de bloqueo una imagen en blanco [final 1](#Final-1)
2. dejar de imagen de bloqueo un screenshot de una nota que pide perdón [final 2](#Final-2)
3. dejar de imagen de bloqueo una imagen normal [final 3](#Final-3)

tras elegir esto el celular se apaga, suena una música y se abre la puerta de la habitación del personaje principal

Tras esto empezara a sonar la puerta principal muy fuerte, alguien toca y no sabemos por que "abre la puerta" "por favor" "se que estas ahí" "heeeeee-...!!!!" el grito se corta a la mitad al entrar en la habitación principal (esta se abre al revisar el celular).

Al entrar se aprecia una cama, un mueble con una lampara a demás de un escritorio con un computador cerrado, aun así la luz tenue de la lampara genera el sentimiento de vació.

 El computador esta bloqueado y obviamente no conoces la contraseña.

La cama es un objeto con el que puedes interactuar, y al acercarte a la cama tu personaje se acuesta en ella y duerme, al hacerlo todo se pone en negro y ves a tu personaje caer y todo se va a obscuro mientras tu caída se expande cada vez mas.

---

## Final 1 (Pesar)

se genera al elegir como fondo de pantalla una nota pidiendo perdón

El jugador llega a un pasillo largo cubierto de fotos que ahogan las paredes, frente a el hay una puerta y al abrirla lo único que  diferencias es un blanco segador **inicia una música angelical de violín la cual representa paz y de una forma peculiar, llegando a las notas altas de este, baja rotundamente a notas rotas sin armonía y con un fin terrorífico, algo anda mal**, se apagan las luces, detrás de ti no hay nada mas que una lampara apuntando hacia un teléfono sobre una mesa (referencia a stanley parable).

Este sonara y al acercarte e interinar con el suenan risas, niños riendo, el juego se funde a negro, se aprecia una puerta en un fondo negro(continuara) (el juego se cierra permitiendo al jugador sentirse solo y quedarse con el silencio de su escritorio)... 

> Cuidado con la obscuridad del pasaje conocido,<br>las cosas desaparecen y aparecen cuando no las vez,<br>el remordimiento atormentara al que no esperaba una pérdida <br>y la muerte buscara a quien no se espere su aparición.

---

## Final 2 (Culpa)

se genera al elegir como fondo de pantalla del celular una "imagen de una nota de suicidio pidiendo perdón".

**Se que es difícil de afrontar especialmente después de cagarla como la cague contigo, espero que si no me perdones en esta vida puedas hacerlo en la siguiente, aveces solo quería desaparecer contigo, pero no fui yo el que desapareció sino tu y tu luz, no es una despedida, sino un hasta luego, especialmente al recordar que todas las mentiras que dijeron de mi, me llevaron a elegir el camino mas fácil y especialmente el que demuestra que lo siento realmente, aun mas el que me permite decirte que lo siento, específicamente a ti, aun que no quieras, nos en el cielo.. si este aun existe para mi.**

**~~con amor para~~ (tajado) tu sabes quien eres.**

Al llegar al pasillo este tiene en las paredes múltiples imágenes del payaso pero cambiadas por una cara grotesca que mira fijamente al jugador.

Todas estas te ven directamente y solo se logra ver una puerta al final de este pasillo y unas pocas cosas en la misma sala, los múltiples murmullos dejan de escucharse.

Al entrar en la puerta esta se cierra y lentamente aparece la misma imagen constantemente en la misma habitación "se escuchan risas y estas se hacen mas ruidosas, cuando llegan a cierto punto, toda la habitación se vuelve roja brillante, los gritos paran y el juego se cierra".

(Al iniciar el juego de nuevo se ve la habitación del inicio pero en la cocina hay una luz negra, la imagen de la pared tiene la cara macabra y en la tele se ven letras que al unirse generan la palabra "es tu culpa", "tu lo hiciste" y "valió la pena?","**¿Quien es el payaso? cuya vida es un cúmulo emocionante de mierda y su chiste mas gracioso es su propia existencia.**").

---

## Final 3 (Indiferencia)

El personaje llega a un pasillo obscuro donde  lo único que aprecia es la puerta abriéndose, el fondo es obscuro y vació, apenas denotas algún tipo de objeto al fondo, al entrar se prende una luz al final de un túnel muy lejano, al llegar todo termina como en el final de "**Culpa**".

---

# Project_Al0n3 acto 2

**coming soon**