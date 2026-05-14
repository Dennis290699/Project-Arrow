\subsection{Estructura}

\subsubsection*{Organización general}

La estructura del videojuego se organiza en distintas zonas temáticas conectadas de forma progresiva, donde cada sección introduce nuevos desafíos, enemigos, elementos narrativos y variaciones ambientales que enriquecen la experiencia del jugador. Cada nivel busca reforzar mecánicas previamente aprendidas mientras incrementa gradualmente la dificultad y profundiza en la historia de la caída del reino.

Aunque el prototipo desarrollado en esta etapa incluirá únicamente una zona jugable completa, la arquitectura general del proyecto se encuentra diseñada considerando futuras expansiones que permitan incorporar nuevas áreas sin modificar la base estructural del videojuego.

Cada zona posee además una identidad visual y sonora propia, apoyándose en el sistema musical y ambiental para reforzar emocionalmente la exploración y la narrativa del juego.

\vspace{0.3cm}

\subsubsection*{Jardines Marchitos}

Los \textit{Jardines Marchitos} constituyen la primera zona jugable y funcionan como nivel introductorio del prototipo. Presentan espacios relativamente abiertos, plataformas simples y enemigos básicos que permiten enseñar progresivamente las mecánicas principales del videojuego, incluyendo movimiento, salto, combate a distancia, exploración y recolección de objetos.

El diseño del escenario debe favorecer el aprendizaje natural mediante una distribución clara de plataformas, obstáculos y rutas opcionales. El jugador debe familiarizarse con la movilidad de Sir. Garet sin enfrentar una dificultad excesiva durante los primeros minutos de juego.

Los enemigos iniciales incluyen el \textit{Arquero Corrompido}, el \textit{Ninja de la Sombra} y el \textit{Esqueleto Reanimado}. Cada uno introduce patrones básicos de combate y movimiento que ayudan al jugador a comprender las mecánicas defensivas y ofensivas del videojuego.

Visualmente, la zona debe transmitir decadencia y abandono mediante árboles secos, vegetación marchita, estatuas destruidas, rejas oxidadas y estructuras parcialmente derrumbadas.

\vspace{0.3cm}

\textbf{Mazmorras del Eco.}  
Planeadas para futuras integraciones del proyecto, las \textit{Mazmorras del Eco} representarían una transición hacia una experiencia más oscura y desafiante. Esta zona puede incorporar espacios cerrados, plataformas más peligrosas, trampas ambientales y enemigos con comportamientos más agresivos.

La estructura del nivel puede centrarse en recorridos verticales, pasillos estrechos y áreas ocultas que incentiven la exploración cuidadosa del entorno. La atmósfera debe enfatizar encierro, tensión y peligro constante.

\vspace{0.3cm}

\textbf{Torre del Hechicero.}  
La \textit{Torre del Hechicero} corresponde al posible clímax del videojuego en futuras versiones completas del proyecto. Su diseño puede orientarse hacia una progresión más lineal y desafiante, incorporando enemigos avanzados, plataformas complejas y eventos narrativos importantes relacionados con el enfrentamiento final.

Visualmente, esta sección debe transmitir corrupción mágica y peligro mediante estructuras imponentes, iluminación sobrenatural y elementos arcanos presentes en el entorno.

\subsubsection*{Construcción técnica del entorno}

El escenario se desarrolla utilizando una estructura modular basada en cuadrículas, permitiendo organizar plataformas, obstáculos y superficies de manera uniforme y reutilizable. Este enfoque facilita la creación de niveles consistentes, mejora la organización visual del entorno y permite expandir el videojuego con nuevas zonas de forma más eficiente.

La construcción modular también favorece futuras ampliaciones del proyecto, permitiendo añadir biomas, rutas alternativas y nuevos segmentos narrativos sin alterar la lógica principal de diseño del escenario.

Para optimizar el rendimiento, las superficies sólidas pueden agruparse mediante colisiones unificadas, reduciendo cálculos físicos innecesarios y mejorando la estabilidad del sistema durante la ejecución del videojuego.

Adicionalmente, la estructura técnica del entorno debe permitir integrar elementos interactivos como puntos de control, plataformas móviles, trampas, eventos activados por exploración, facilitando la evolución progresiva del diseño de niveles en futuras versiones del proyecto.