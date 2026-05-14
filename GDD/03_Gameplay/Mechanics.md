\subsection{Mecánicas principales}

\subsubsection*{Movimiento físico}

El desplazamiento del personaje se basa en la manipulación directa de su velocidad horizontal. Esta decisión busca evitar movimientos imprecisos o inercias innecesarias, garantizando una respuesta inmediata y consistente para el jugador. La sensación de aceleración puede reforzarse mediante animaciones, aunque el comportamiento mecánico debe conservar claridad y precisión en todo momento.

\subsubsection*{Sistema de salto}

El salto funciona mediante una detección precisa del contacto con el suelo a través de una verificación ubicada en la parte inferior del personaje. Este mecanismo permite determinar si existe una superficie válida antes de habilitar un nuevo salto.

Para mejorar la percepción de peso y control, el descenso del personaje utiliza una caída más rápida que el ascenso. Este ajuste incrementa la sensación de impacto al aterrizar y evita que los saltos se perciban excesivamente ligeros o flotantes.

\subsubsection*{Combate a distancia}

El ataque principal consiste en el lanzamiento de flechas mágicas o proyectiles equivalentes. Cada proyectil se genera frente al personaje y se desplaza en la dirección seleccionada con una velocidad determinada.

El sistema de combate busca ofrecer precisión y rapidez de respuesta, permitiendo al jugador atacar mientras se desplaza o evade obstáculos. Además, este enfoque amplía las posibilidades estratégicas frente a enemigos ubicados a distintas distancias.

\subsubsection*{Economía interna}

Los enemigos derrotados y determinadas áreas ocultas recompensan al jugador con \textbf{Diamantes de Almas}. Estos objetos funcionan como moneda interna y pueden utilizarse en puntos de guardado o estatuas especiales para desbloquear mejoras.

Las mejoras principales contemplan el aumento de salud máxima, el incremento del daño base y futuras extensiones relacionadas con habilidades o energía mágica.

\subsubsection*{Retroalimentación al jugador}

Cada acción importante debe comunicar claramente su resultado mediante efectos visuales, sonido, animaciones e interfaz. Los ataques exitosos deben generar señales visibles de impacto; la recolección de recursos debe diferenciarse mediante efectos distintivos; y el daño recibido debe reflejarse de forma inmediata a través de indicadores visuales y un breve periodo de invulnerabilidad temporal.