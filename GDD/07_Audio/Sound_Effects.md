\subsection{Efectos de sonido}

\subsubsection*{Principios generales}

Los efectos de sonido constituyen uno de los elementos fundamentales para reforzar la interacción y la inmersión dentro del videojuego. En el caso del prototipo de \textit{Chronicles of the Cursed Knight}, los efectos deben proporcionar retroalimentación inmediata sobre las acciones del jugador y complementar la atmósfera fantástica y melancólica del entorno.

Cada acción importante realizada por el jugador debe poseer una respuesta sonora clara y fácilmente reconocible. Esto incluye movimientos básicos como caminar, saltar y aterrizar, así como acciones de combate, recolección de objetos y recepción de daño. La correcta implementación de estos sonidos permitirá que el jugador perciba con mayor precisión el impacto de sus acciones dentro del mundo del juego.

Debido a la naturaleza \textit{pixel art} del proyecto, se recomienda utilizar efectos de sonido estilizados que mantengan coherencia con la estética retro del videojuego. Los sonidos no deben ser excesivamente realistas, sino presentar un equilibrio entre simplicidad arcade y ambientación medieval fantástica.

Asimismo, los efectos deben evitar la saturación auditiva. Durante secuencias con múltiples acciones simultáneas, el sistema de audio debe priorizar sonidos relevantes para mantener claridad y evitar fatiga sonora en el jugador.

\subsubsection*{Efectos principales}

\textbf{Pasos.}  
Los sonidos de pasos deben acompañar constantemente el desplazamiento del personaje y transmitir sensación de movimiento físico dentro del escenario. Para evitar repetición perceptible, se recomienda utilizar pequeñas variaciones aleatorias de tono y volumen mediante código. En futuras expansiones del proyecto, diferentes superficies del entorno pueden modificar el timbre del sonido, distinguiendo entre piedra, madera, tierra o superficies mágicas.

Los pasos de Sir Gareth pueden incorporar ligeros sonidos metálicos asociados a su armadura ligera y equipamiento de arquero, reforzando su identidad como caballero élfico.

\vspace{0.3cm}

\textbf{Salto y aterrizaje.}  
El salto debe incluir un efecto breve y dinámico que refuerce la sensación de impulso y agilidad del personaje. El aterrizaje, por otro lado, debe poseer un sonido ligeramente más pesado que permita al jugador percibir el retorno al suelo y la interacción con la superficie del escenario.

En plataformas elevadas o zonas especiales, el aterrizaje puede incorporar reverberaciones suaves para enfatizar profundidad o altura.

\vspace{0.3cm}

\textbf{Arco y proyectiles.}  
Debido a que Sir Gareth es un arquero, los ataques a distancia representan uno de los sonidos más importantes del videojuego. Cada disparo debe incluir varias capas de sonido:

\begin{itemize}
    \item Liberación de la flecha.
    \item Desplazamiento de aire durante el recorrido.
    \item Impacto diferenciado según el objetivo alcanzado.
\end{itemize}

Cuando una flecha impacte contra un enemigo, el sonido debe transmitir contundencia y precisión. En cambio, si golpea paredes u objetos del escenario, el efecto puede presentar resonancias más secas o metálicas dependiendo del material.

\vspace{0.3cm}

\textbf{Combate e impactos.}  
Los enemigos deben emitir sonidos de impacto, daño y derrota que permitan identificar claramente el resultado de los ataques del jugador. Los enemigos pequeños pueden utilizar sonidos rápidos y agudos, mientras que enemigos de mayor tamaño deben incorporar efectos más graves y pesados para transmitir sensación de amenaza.

Los enfrentamientos importantes o jefes pueden incluir rugidos, sonidos mágicos o efectos especiales asociados a sus habilidades particulares.

\vspace{0.3cm}

\textbf{Recolección de objetos.}  
Los \textit{Diamantes de Almas} deben emitir un sonido agudo, breve y satisfactorio, similar a una campana cristalina o un eco mágico. Este efecto debe reforzar psicológicamente la recompensa obtenida por el jugador y diferenciar claramente los objetos importantes del resto de elementos interactivos.

Otros objetos coleccionables o mejoras futuras pueden reutilizar variaciones del mismo patrón sonoro para mantener coherencia auditiva dentro del juego.

\vspace{0.3cm}

\textbf{Daño y estado del jugador.}  
El daño recibido por Sir Gareth debe representarse mediante un sonido claro pero no excesivamente intrusivo. El objetivo es alertar al jugador sin generar molestia auditiva durante combates continuos.

Cuando la salud del personaje sea baja, pueden añadirse efectos ambientales adicionales como latidos suaves, respiración agitada o reducción parcial de ciertos sonidos del entorno para aumentar la tensión y dramatismo.

\subsubsection*{Sonido ambiental}

El entorno debe complementarse mediante sonidos ambientales que fortalezcan la inmersión del jugador dentro de cada zona. Estos sonidos funcionan como capas pasivas que enriquecen la atmósfera sin interferir con la jugabilidad principal.

En los \textit{Jardines Marchitos} pueden utilizarse sonidos de viento, hojas secas y naturaleza deteriorada. Las \textit{Mazmorras del Eco} pueden incorporar gotas de agua, cadenas lejanas y reverberaciones profundas que transmitan aislamiento y misterio. Por su parte, la \textit{Torre del Hechicero} puede incluir energía mágica, vibraciones arcanas y ecos sobrenaturales relacionados con la confrontación final.

La combinación entre música ambiental y efectos del entorno permitirá construir una experiencia auditiva más rica y coherente con la narrativa del videojuego.

\subsubsection*{Implementación técnica}

Los objetos y personajes clave deben utilizar componentes \texttt{AudioSource} dentro de Unity para gestionar la reproducción de sonidos individuales. La administración global del sistema de audio puede centralizarse mediante un \texttt{AudioManager}, encargado de organizar y controlar todos los elementos sonoros del juego.

Entre las responsabilidades principales del sistema de audio se incluyen:

\begin{itemize}
    \item Separar canales de música, efectos de sonido y ambiente.
    \item Controlar niveles de volumen independientes.
    \item Gestionar reproducción simultánea de múltiples sonidos.
    \item Implementar variaciones aleatorias de tono y volumen.
    \item Optimizar recursos reutilizando efectos frecuentes mediante \textit{audio pooling}.
    \item Facilitar futuras expansiones del prototipo.
\end{itemize}

Adicionalmente, Unity permite utilizar mezcladores de audio (\texttt{AudioMixer}) para aplicar efectos como reverberación, eco o filtros de frecuencia dependiendo del entorno del nivel. Esto puede contribuir significativamente a mejorar la percepción espacial y la atmósfera general del videojuego.

\subsubsection*{Catálogo Detallado de Efectos de Sonido (SFX)}

Para asegurar la coherencia auditiva, se define el siguiente listado preliminar de efectos de sonido para el prototipo, detallando su comportamiento acústico y prioridad en el mezclador:

\begin{center}
\begin{tabular}{|p{3.2cm}|p{4.2cm}|p{4.8cm}|p{2cm}|}
\hline
\textbf{Identificador SFX} & \textbf{Descripción Físico-Acústica} & \textbf{Comportamiento en Unity} & \textbf{Prioridad} \\
\hline
\texttt{sfx\_footstep\_stone} & Ruido seco y agudo de bota con leve tintineo metálico de cota de malla. & Pitch aleatorio ($0.9$ - $1.1$). Volumen bajo. & Media \\
\hline
\texttt{sfx\_footstep\_dirt} & Sonido sordo y crujiente de hojas secas y tierra suelta al pisar. & Pitch aleatorio ($0.85$ - $1.05$). Volumen bajo. & Media \\
\hline
\texttt{sfx\_jump} & Silbido rápido ascendente de viento. & Pitch fijo. Reproducción única en despegue. & Alta \\
\hline
\texttt{sfx\_double\_jump} & Destello brillante mágico con resonancia cristalina en frecuencias altas. & Filtro de eco menor. Volumen medio. & Alta \\
\hline
\texttt{sfx\_dash} & Ráfaga súbita y violenta de aire desplazado con fuerza física. & Atenuación rápida de graves. Volumen alto. & Alta \\
\hline
\texttt{sfx\_bow\_pull} & Crujido tenso de madera vieja doblándose junto al roce de la cuerda. & Tono progresivo ascendente durante la carga. & Alta \\
\hline
\texttt{sfx\_bow\_release} & Latigazo metálico seco de la cuerda de arco al soltarse. & Reproducción síncrona con la instancia física. & Muy Alta \\
\hline
\texttt{sfx\_arrow\_impact\_org} & Golpe húmedo y sordo al impactar carne o madera podrida. & Pitch aleatorio ($0.95$ - $1.05$). & Muy Alta \\
\hline
\texttt{sfx\_arrow\_impact\_env} & Impacto seco con desprendimiento de gravilla en piedra o metal. & Pitch agudo. Rebote sonoro breve. & Media \\
\hline
\texttt{sfx\_soul\_diamond} & Campanilla cristalina con vibración y resonancia aguda ascendente. & Tono alto. Filtro de reverb corto. & Alta \\
\hline
\texttt{sfx\_checkpoint\_act} & Rizo ascendente de sintetizador celestial acoplado a campanas lejanas. & Volumen alto, paneo estereofónico completo. & Muy Alta \\
\hline
\texttt{sfx\_saw\_trap\_loop} & Zumbido mecánico continuo de sierra de metal girando a alta velocidad. & Paneo y atenuación espacial 3D según distancia. & Alta \\
\hline
\end{tabular}
\end{center}
