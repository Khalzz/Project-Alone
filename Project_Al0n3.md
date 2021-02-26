# Project_Al0n3 acto 1

Project_Al0n3 es un juego de terror psicológico, la idea detrás de este es mantenerse corto pero intentar dejar una idea de vacío en tanto el jugador como algún posible espectador.

## Cosas a tomar en cuenta

+ El juego toma el suicidio del personaje principal como punto detonante.
+ El protagonista despierta sin saber que es, donde esta ni quien es.
+ Una de las ideas principales es que el desarrollo del personaje se mantenga en el jugador en base a experiencias representadas en los sueños que el protagonista tiene al irse a dormir.
+ ***El protagonista no habla a cámara, todo lo que sabemos o la mayoría debe venir de texto y ruidos exteriores.***
+ El camino del protagonista debe terminar un dia cualquiera a las 3 de la mañana, a esa hora se debera hacer una coneccion entre el "mundo espiritual (donde se encuentra el personaje)" y el mundo real.
+ Esto permite ver al jugador las puertas abiertas (con papel policial) el baño abierto con sangre en la bañera y mas importante aun con un cuerpo dentro de una bolsa negra y en la pared tras el sofa un monton gigantesco de sangre como si alguien la hubiera tirado en la pared con odio, o con pena...
+ Lo que parece una despedida tierna y hasta poética, se transforma en el purgatorio, un lugar obscuro sin alma alguna pero algo te ve y no sabes que.
+ En la cercanía entre un tipo de niebla extraña se distinguen caras siniestras y risas constantes (Idea en proceso).

---

## Punto Técnico

En esta parte de la documentación voy a hacer énfasis de problemas técnicos tanto como de consejos tomando en cuenta el carácter técnico del proyecto, iniciando por un tema muy importante

+ Error de el maldito material que no se carga al prender la luz (este error se genera no se por que pero aveces el material no carga "específicamente el color de el emission") **Arreglado, aparentemente...**
  + esto se repara habilitando tanto el material y la luz en el editor, al iniciar el juego apagamos las luces y salimos del "juego" luego de esto desactivamos las luces y por alguna razón ahí se repara el error.
  + cabe resaltar que no se si es una forma oficial de arreglarlo pero me ha funcionado :b.
  
  **actualmente la solución era "iniciar el material como apagado en el script "Light.cs" en su start** así este iniciara con ese estado básico y su estado básico no se basara en como esta el material en el elemento
---

## Peticiones de diseño

> Cuidado con la obscuridad del pasaje conocido,<br>las cosas desaparecen y aparecen cuando no las vez,<br>el remordimiento atormentara al que no esperaba una pérdida <br>y la muerte buscara a quien no se espere su aparición.

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

+ **Post its en la cocina**

  Al entrar en la cocina, se aprecian distintos post it.

  + 2 al lado cercano del interruptor de luz.
  + 1 en el refrigerador.
  + 2 en la pared apegada al refrigerador.
  + 7 en la pared al final del corredor de la cocina.

  La función de estos debería ser representar los "actos" del protagonista como una historia ficticia la cual deberá en segundo plano ser una ilustración detallada de lo que el protagonista le hizo a una persona desconocida antes de acabar en su estado actual.

  >Entre las entrañas del humo y las sombras apareció el, dándole la mano a la niña para salvarla del barro y el mal aparente en la obscuridad de la noche.

  > Entre llantos y gritos sus captores buscaban la forma de tenerla de vuelta, el hombre la atrajo a un vehículo con el que condujo hacia su hogar.

  > (en el refrigerador) lista de compra:
>
  > + leche
  > + huevos
  > + pan
> + ~~frutas~~ (no alcanza)
  > + ~~harina~~ (no alcanza)
  > + **ginebra**
  > + **cigarros**
  >
  > estos 2 últimos deben estar MUY remarcados

  > Allí le presento su nueva vida, finalmente la niña nunca volvería a tener alguna necesidad.

  > Una noche la niña despertó entre sollozos y rompió en llanto sintiéndose sola, el hombre, su príncipe vino a su rescate y con la suavidad de sus manos y el poder de un beso, logro salvarla de ese llanto incontrolable, la joven volvió a dormir mientras abrazaba la almohada como si esta no quisiera dejarla ir nunca.

  > Al despertar sintió un frió sentimiento metálico junto con un dolor agudo al rededor de sus piernas, los cortes se combinaban con frió del hielo tocando su cuerpo casi sedado.

  > Su cuerpo se sentía helado, aun que no sabia si era por el agua y hielo que la rodeaba o por el mismo sedante que lentamente apagaba el dolor que provenía de sus piernas.

  > inmediatamente empezó a sentir los cortes en sus brazos, pero lentamente este dolor se transformo en una sensación cálida.

  > Cuando el dolor se acerco a su pecho todo se volvió obscuro, no sentía su cuerpo pero aun así se sentía muy viva.

  > Al quitarse la venda que cubría sus bellos ojos ya nadie la acompañaba, estaba sola en una bañera cubierta de hielos teñidos de rojo.

  > Pero al levantarse se veía totalmente intacta, su piel seguía suave como la seda, al salir del tétrico baño vio una hermosa sala, pero bañada en una niebla tan densa al aire, como la sangre al agua.

  > La puerta principal no presentaba algún bloqueo pero ella no era capaz de abrirla, como si sus fuerzas se desvanecieran al acercarse a la misma, ella no sentía que debiera irse pues finalmente descubrió la paz que ese lugar le generaba.

  > Desde ese día habita las salas sola, abriendo y cerrando puertas al azar, a veces puede ver al príncipe que la llevo ahí y recuerda esos días de paz y compañía, deseando volver y abrazar al hombre que la hizo tan feliz.

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

+ La habitación puedes abrirla fácilmente y en su interior ves tu habitación, una cama grande, un mueble con una lampara que genera una luz tenue y un escritorio con un computador cerrado/apagado.

  ---

+ La cocina esta abierta, tu única limitación de entrar a ella es que esta cubierta de una obscuridad que te ahoga en miedo el verla, de hecho no podrías decir que es una cocina sin prender la luz.

  La cocina aun con la luz prendida se ve obscura, el jugador al entrar en ella ve varias cosas de interés, desde post-its en tanto el refrigerador como en una pared en su lado obscuro como variedad de platos sucios entre otras cosas (al acercarte a el post-it en la parte obscura suena un violín de aspecto terrorífico en un crescendo que termina en una forma fría pero haciendo una transformación drástica hacia una música que sale del refrigerador)
  
  ---

La cama es un objeto con el que puedes interactuar, al acercarte a la cama tu personaje se acuesta en ella y duerme, al hacerlo todo se pone en negro.

---

# Project_Al0n3 acto 2

Al cerrar los ojos apareces en un lugar totalmente obscuro y a lo lejos ves una puerta junto a una linea blanca que te ayuda a definir el camino hacia ella.

Al salir de esa rara habitación obscura como el vació mismo puedes observar con claridad que estas dentro de una cueva, ciertas linternas te iluminan el camino hacia una esquina.

**dato técnico: **al llegar a esa esquina y perder toda la capacidad de ver la habitación en la que estabas esta debe desaparecer (preferiblemente adelantar una "roca" para dar la ilusión de que es parte de la cueva)

Tras avanzar unos pasos encuentras 2 agujeros separados por piedra maciza y con un cartel entre medio con 2 flechas:

+ go :D -->

+ <-- don't go D:

  el cartel de "dont't go" esta manchado en sangre y lo único que distingues de ambas entradas es que la que dice "go" esta bien iluminada mientras que la contraria contiene una pequeña muestra de luz

  (**plot twist: ambas puertas te llevan al mismo lugar y no afectan nada tu avance**)

Al llegar a la salida de la cueva ves que estas encerrado dentro de una sala similar a un salón de clases a obscuras y en una pared lejana aprecias una pequeña puerta blanca brillante la cual al ser abierta te permite entrar a una sala gigante y vacía, una habitación totalmente negra como la del principio.

Al final de un largo puente encuentras un pequeño espacio circular.

En esta se puede ver un teléfono sobre una mesa circular abrupta mente iluminada por una luz colgada del techo (referencia a Stanley Parable).

al acercarte este empieza a sonar y si interactuas con el teléfono este cae y se contesta (la música se para abrupta-mente y inicia una música un poco burlona).

(se escucha a un hombre balbucear)

\-  **(se aclara la garganta)** entonces, el jugador entra a la habitación (se prende una luz alumbrando a la puerta) camina por la pasarela lentamente (se prende una luz en el puente) y finalmente, el jugador contesta el teléfono! (se mantiene un tono de intriga alto hasta que el jugador realmente interactua con el teléfono.) 

Ahhhhhh, jugador? que haces aquí?, deberías estar en otro juego mientras este se termina, no aquí hablando conmigo, estas loco? sabes lo que hara el programador cuando se entere de que estoy interactuando contigo antes de tiempo?.

Ah mierda, ni siquiera esta terminado el juego!!!, AHHHHH.

Bueno, quizá deberé hacerte un apoyo antes de tiempo.

**(una puerta se abre tras el teléfono)** bueno, sal por esa puerta si eres tan amable, así saldrás del juego y podrás hacer otras cosas mientras el juego se termina. (si el jugador sale de la habitación por la puerta el juego se cerrara).

La puerta te espera!

No crees que el otro lado de esa puerta se ve un poco... Sexy (decir con voz sensual).

Bueno, veo que tu gusto por las puertas no es tan fuerte como el mio, si me perdonas la puerta sera para mi (la puerta se cierra)

Bueno, seamos un poco mas técnicos (se escucha un foco prenderse) ahí puedes ver un interruptor, este apagara el juego al ser presionado y te va a permitir ir a hacer otras cosas mientras tanto.

No es por culpar al programador, pero no has notado que no existe un botón de salir aun?.

Ve y tira de la palanca.

Vamos!!!!.

Bueno si no quieres hacerlo tendré que ponerme diplomático.

O jalas de esa palanca!!! o te asustare!!!!.

Wow, bueno, me veo en obligación de hacerlo, aquí va. (la música se para, inicia una música tensa y tras unos segundos aparece un gatito en un png)

ven, puedes acariciar el gatito (si acaricias el gatito con tensión este solo va a maullar)

oh que raro, nada ha ocurrido, bueno aun puedes venir y presionar la palanca (el jugador al darse vuelta recibe un screamer (ideal que sea ligero y algo muy tonto))

hahahahahahahaah, sabia que lo lograría, caíste en el truco mas viejo en el libro.

bueno, te dejare pasar pero trata de no contarle al programador de que estas aqui, si lo ves dile que el diseñador te dejo continuar ok?, bueno usa esta puerta para despertar (se abre una puerta, si la pasas todo se pone en negro y salta un screamer con el gatito) Hehehehehe, nunca falla (el jugador se despierta).

---

Project_Al0n3 acto 2