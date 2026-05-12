\subsection{Riesgos de diseño}

\subsubsection*{Scope creep}

El alcance excesivo puede surgir si el equipo intenta crear demasiados niveles, enemigos, mecánicas o sistemas narrativos para el tiempo disponible. Esto puede llevar a una experiencia incompleta y poco pulida.

\textbf{Mitigación.} Se adopta una filosofía de corte vertical. Es preferible completar un nivel con el cien por ciento de las mecánicas principales funcionando que producir varios niveles vacíos o incompletos.

\subsubsection*{Balance}

Una dificultad mal calibrada puede hacer que el juego resulte frustrante o demasiado simple. Esto afectaría la percepción de calidad del prototipo. Este riesgo se refleja en la codebase actual a través de variables ajustables observadas en scripts como \texttt{Assets/Scripts/Player.cs} (salud, velocidad de movimiento, fuerza de salto), \texttt{Assets/Scripts/PlayerDash.cs} (parámetros de dash) y scripts de enemigos que definen daño y velocidad.

\textbf{Mitigación.} Se implementarán variables ajustables para daño, vida, velocidad, recursos y ubicación de checkpoints. El balance final se realizará durante la fase de QA.
