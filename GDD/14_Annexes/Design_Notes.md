\subsection{Notas de Desarrollo e Inspiración Creativa}

Este apartado expone el diario de diseño creativo y los orígenes conceptuales detrás de las decisiones de nomenclatura, narrativa y mecánicas del prototipo de \emph{Chronicles of the Cursed Knight}. Se detallan las referencias de la cultura real, juegos de palabras y las justificaciones del enfoque del juego.

\subsubsection*{El Origen Creativo de los Nombres de los Personajes}

La nomenclatura de las figuras clave del juego nació de anécdotas y asociaciones de ideas de los desarrolladores durante las fases iniciales de tormenta de ideas (\emph{Brainstorming}):

\begin{itemize}
    \item \textbf{Sir Gareth (El protagonista):} El nombre del protagonista surgió de un juego de palabras fonético en inglés con la palabra \textit{"cigarettes"} (cigarrillos). Aunque inicialmente comenzó como una broma interna del equipo de desarrollo, se integró profundamente en la temática del personaje: Sir Gareth es un elfo maldito cuyo cuerpo se consume lentamente a causa de una infección necrótica, desintegrándose en polvo. Su carne y su destino se "queman" de forma progresiva, convirtiéndolo en un recipiente de cenizas andante, lo que justifica la ironía de su nombre.
    \item \textbf{Elara (La sacerdotisa):} El nombre de la sacerdotisa y guía espiritual se inspiró en el nombre real de una compañera de clases del equipo de desarrollo llamada \emph{Elena}. Con el fin de adaptar el nombre a la estética de fantasía oscura y elfo-gótica del juego, el equipo de diseño de narrativa alteró la fonética y suavizó las consonantes hasta convertirlo en \emph{Elara}, otorgándole un tono místico, etéreo y literario.
\end{itemize}

\subsubsection*{El Origen del Cataclismo y los Escenarios}

Siguiendo la coherencia temática del juego de palabras del protagonista, el resto del mundo y sus tragedias fueron bautizados bajo el mismo concepto creativo, complementado con anécdotas y decisiones técnicas de producción:

\begin{itemize}
    \item \textbf{La Noche de la Ceniza (El Cataclismo):} En honor a la analogía del cigarrillo (\textit{cigarettes} $\rightarrow$ Gareth), el evento apocalíptico que destruyó el reino y consumió la vida de los elfo se denominó "La Noche de la Ceniza". La idea conceptual de que un cigarrillo encendido se consume hasta convertirse en cenizas se tradujo narrativamente en la devastadora lluvia de ceniza necrótica que cubrió los bosques y calcinó las almas de Valtheria cuando se rompió la reliquia.
    \item \textbf{Valtheria (El Reino):} Este nombre surgió en una sesión de lluvia de ideas cuando un integrante del equipo intentó traducir de manera tosca la expresión "Valle de la Tierra" al inglés como "Val-Earth-ia" (Valtheria). Al equipo le gustó la sonoridad majestuosa del término, la cual evocaba fonéticamente una mezcla entre *Val* (valle de la naturaleza) y *Aetheria* (éther celestial), representando una civilización en comunión con las fuerzas divinas.
    \item \textbf{Eldergrove (El Bosque Sagrado):} El nombre nació de una confusión divertida. Durante la fase de investigación de referencias visuales, un desarrollador leyó apresuradamente el título del juego "Elder Scrolls" como "Elder Grove" (arboleda antigua). Al notar el error, el equipo consideró que la combinación de \emph{Elder} (anciano/sabio) y \emph{Grove} (santuario de árboles) era el nombre idóneo para describir al bosque místico del Gran Árbol Sagrado.
    \item \textbf{Jardines Marchitos (Nivel 1):} En los bocetos iniciales, esta área se denominaba "Jardines Reales". Sin embargo, al importar los primeros assets de texturas oscuras y grises y definir la maldición de Sir Gareth, el equipo decidió renombrarlos como "Marchitos" para que el jugador captara de forma instantánea la atmósfera decaída y el tono de fantasía gótica nada más comenzar el juego.
    \item \textbf{Mazmorras del Eco (Nivel 2):} Este nombre tiene un origen técnico. En las primeras pruebas de integración del audio en Unity, un fallo en la configuración del filtro de reverberación (\emph{Reverb Zone}) provocó que los sonidos del jugador y de las sierras mecánicas se multiplicaran con un eco masivo. En lugar de solucionarlo de inmediato, el equipo consideró que este sonido de eco le otorgaba una identidad acústica única al entorno y adaptó el lore: las mazmorras pasaron a llamarse "del Eco", teorizando que la piedra absorbió el dolor de los prisioneros del pasado en forma de eco mágico.
    \item \textbf{Torre Marchita / Torre del Hechicero (Nivel 3):} Inicialmente planificada de forma genérica como "La Torre del Hechicero". Para unificar estéticamente los escenarios del corte vertical y mostrar la expansión de la plaga, el equipo adoptó la nomenclatura de "Torre Marchita", sugiriendo que la corrupción de la ceniza se originó en la cúspide de la torre y se propagó hacia abajo hasta marchitar los jardines reales.
\end{itemize}

\subsubsection*{Justificación del Enfoque de la Historia y las Mecánicas}

La decisión de centrar la narrativa en la culpa y la búsqueda de redención, en lugar de una fantasía de poder convencional, sirvió para justificar y entrelazar de forma orgánica las mecánicas de juego programadas en Unity:

\begin{enumerate}
    \item \textbf{Ausencia de Combate Cuerpo a Cuerpo:} Dado que el cuerpo de Sir Gareth está corrompido y en proceso de descomposición física constante, recibir impactos físicos directos aceleraría su muerte. Por ello, es mecánicamente incapaz de golpear cuerpo a cuerpo. Su diseño se enfoca en el combate a distancia mediante flechas mágicas de su arco largo y en la evasión rápida (Dash) para evitar cualquier contacto físico con los enemigos.
    \item \textbf{El Rol del Eco de Elara:} Dado que Gareth no puede regenerarse de forma natural, necesita de las zonas seguras purificadas por el Eco de Elara (Checkpoints) para gastar sus Diamantes de Almas. El proceso de mejora en la tienda representa la purificación temporal de su carne marchita por parte del alma de Elara, permitiéndole soportar más daño ($HP_{max}$) o canalizar mayor energía en sus proyectiles.
    \item \textbf{La Naturaleza de los Enemigos:} Los enemigos son un recordatorio constante del fracaso de Gareth. Al ser antiguos exploradores (Ninjas) y centinelas (Arqueros) de su propia Orden, Gareth se enfrenta a los fantasmas físicos de las personas que prometió proteger y que murieron debido a su negligencia en la Noche de la Ceniza.
\end{enumerate}
