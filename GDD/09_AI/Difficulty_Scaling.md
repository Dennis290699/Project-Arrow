\subsection{Escalabilidad de la dificultad}

Para mantener al jugador en un estado de flujo constante (\emph{Flow State}) y asegurar que el juego ofrezca un reto constante a medida que adquiere mejoras en los checkpoints, los atributos de los enemigos se escalan según la zona en la que se generan.

\subsubsection*{Modelo matemático referencial de escalado}

El escalado de salud de los enemigos por zona no es estrictamente lineal. Se utiliza una función exponencial para calcular la salud máxima, lo que permite absorber el daño fraccional generado por la mejora del $+20\%$ del jugador. Por el contrario, el daño infligido por los enemigos se mantiene en números enteros absolutos para interactuar de forma limpia con el sistema de corazones del HUD.

La salud de los enemigos en una zona determinada se calcula según la fórmula:
\[
HP_{zona} = HP_{base} \times (1.5)^{Z-1}
\]
Donde $Z$ es el número de la zona actual ($Z = 1$ para los Jardines Marchitos, $Z = 2$ para las Mazmorras del Eco, y $Z = 3$ para la Torre del Hechicero). El resultado se redondea a la primera cifra decimal en el código de depuración.

\subsubsection*{Tablas de escalado paramétrico de enemigos}

A continuación se definen los parámetros base y escalados que se inyectan a los ScriptableObjects o Controladores de los enemigos por cada zona del juego:

\paragraph{Tabla 1: Escalado del "Ninja de la Sombra"}
Este enemigo prioriza el incremento de su velocidad de persecución para presionar el uso del Dash por parte del jugador.
\begin{center}
\begin{longtable}{|p{3cm}|p{2.5cm}|p{3.5cm}|p{3cm}|}
\hline
\textbf{Acto / Zona} & \textbf{Salud (HP)} & \textbf{Velocidad Persecución (m/s)} & \textbf{Daño (Melee)} \\
\hline
1. Jardines (Base) & $2.0$ & $3.5$ & $1$ \\
\hline
2. Mazmorras & $3.0$ & $4.2$ & $1$ \\
\hline
3. Torre & $4.5$ & $5.0$ & $2$ \\
\hline
\end{longtable}
\end{center}

\paragraph{Tabla 2: Escalado del "Arquero Corrompido"}
Su escalado se centra en reducir la ventana de evasión del jugador, incrementando la velocidad del proyectil y reduciendo su cooldown de disparo.
\begin{center}
\begin{longtable}{|p{3cm}|p{2.5cm}|p{3.5cm}|p{3cm}|p{2cm}|}
\hline
\textbf{Acto / Zona} & \textbf{Salud (HP)} & \textbf{Velocidad Proyectil (m/s)} & \textbf{Cooldown (s)} & \textbf{Daño} \\
\hline
1. Jardines (Base) & $3.0$ & $10.0$ & $1.5$ & $1$ \\
\hline
2. Mazmorras & $4.5$ & $12.5$ & $1.1$ & $1$ \\
\hline
3. Torre & $6.5$ & $15.0$ & $0.8$ & $2$ \\
\hline
\end{longtable}
\end{center}

\paragraph{Tabla 3: Escalado del "Esqueleto Reanimado"}
Actúa como obstáculo de alta resistencia. Su escalado maximiza la absorción de daño para validar las compras de fuerza en la tienda.
\begin{center}
\begin{longtable}{|p{3cm}|p{2.5cm}|p{3.5cm}|p{3cm}|}
\hline
\textbf{Acto / Zona} & \textbf{Salud (HP)} & \textbf{Velocidad Patrulla (m/s)} & \textbf{Daño (Pesado)} \\
\hline
1. Jardines (Base) & $5.0$ & $1.0$ & $2$ \\
\hline
2. Mazmorras & $7.5$ & $1.2$ & $2$ \\
\hline
3. Torre & $11.0$ & $1.5$ & $3$ \\
\hline
\end{longtable}
\end{center}

\subsubsection*{Consideración técnica de balanceo (Time-to-Kill)}

Si el jugador adquiere dos mejoras de daño consecutivas en el Eco de Elara antes de ingresar a la Zona 3 (Torre del Hechicero), su daño base de $1.0$ escalará mediante la fórmula:
\[
Dmg_{final} = 1.0 \times 1.2 \times 1.2 = 1.44
\]
Al enfrentarse a un Esqueleto Reanimado de la Zona 3 ($11.0$ HP), el número de impactos necesarios para derrotarlo (\emph{Time-to-Kill}) se calcula como:
\[
TTK = \lceil \frac{HP_{enemigo}}{Dmg_{jugador}} \rceil = \lceil \frac{11.0}{1.44} \rceil = \lceil 7.63 \rceil = 8 \text{ impactos}
\]
En contraste, un jugador que no haya comprado ninguna mejora de daño necesitaría $11$ impactos directos para derrotar al mismo enemigo. Este balance asegura que las decisiones económicas tengan un impacto tangible en la jugabilidad sin convertir a los enemigos en esponjas de daño indestructibles.
