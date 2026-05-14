\subsection{Comportamiento de enemigos}

\subsubsection*{Modelo general}

La inteligencia artificial de los enemigos se estructura mediante un sistema de estados que define distintas conductas según la situación del entorno. Este enfoque facilita la organización, mantenimiento y futura ampliación de comportamientos. Los estados principales contemplados son patrulla, persecución, ataque y muerte.

\subsubsection*{Patrulla}

Durante el estado de patrulla, el enemigo recorre una zona determinada mediante desplazamientos horizontales controlados. Para evitar caídas accidentales, el sistema verifica constantemente la presencia de suelo frente al personaje. Si no se detecta una superficie válida, el enemigo cambia de dirección y continúa su recorrido.

\subsubsection*{Persecución}

La fase de persecución se activa cuando el jugador ingresa en el rango de detección del enemigo. Una vez identificado el objetivo, el enemigo ajusta su orientación y comienza a desplazarse hacia la posición del jugador manteniendo una velocidad determinada.

Este comportamiento busca generar presión constante sin comprometer la claridad de lectura del combate.

\subsubsection*{Ataque}

Cuando el jugador se encuentra dentro de la distancia de ataque, el enemigo interrumpe su desplazamiento y ejecuta una acción ofensiva. El daño debe sincronizarse correctamente con la animación para garantizar coherencia entre el impacto visual y el resultado mecánico.

La activación del ataque puede incluir tiempos de recuperación y pausas breves con el fin de equilibrar la dificultad y permitir oportunidades de evasión.

\subsubsection*{Muerte}

Al perder todos sus puntos de vida, el enemigo entra en un estado de derrota donde deja de interactuar físicamente con el entorno y reproduce una animación de muerte. Una vez finalizada esta secuencia, el enemigo desaparece del escenario o queda disponible para reutilización dentro del sistema interno del juego, en otra ubicación.