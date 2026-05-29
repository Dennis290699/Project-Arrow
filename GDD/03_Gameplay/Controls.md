\subsection{Controles}

\subsubsection*{Esquema de controles en PC (Teclado y Ratón)}

Para esta versión del proyecto, el juego se controla exclusivamente mediante periféricos de PC, utilizando una distribución simplificada e intuitiva para juegos de plataformas de acción:

\begin{center}
\begin{longtable}{|p{4cm}|p{8cm}|}
\hline
\textbf{Tecla / Entrada} & \textbf{Acción Asociada en el Juego} \\
\hline
\texttt{W} & Desplazamiento hacia la izquierda \\
\hline
\texttt{D} & Desplazamiento hacia la derecha \\
\hline
\texttt{Espacio} (Barra) & Salto / Doble Salto (al presionarse en el aire) \\
\hline
\textbf{Clic Izquierdo} (Mouse 0) & Ataque de arco (lanzamiento de flecha física) \\
\hline
\textbf{Clic Derecho} (Mouse 1) & Mecánica de evasión (Dash) \\
\hline
\texttt{Esc} & Activación / Desactivación del menú de pausa \\
\hline
\end{longtable}
\end{center}

\subsubsection*{Criterios de usabilidad}

La distribución de los controles está diseñada para que el jugador pueda maniobrar ágilmente con una mano en el teclado (\texttt{W}, \texttt{D} y \texttt{Espacio}) y otra en el ratón (apuntando con la mirada física del sprite y controlando los disparos y esquives con los clics). El sistema permite la introducción simultánea de comandos, de modo que el jugador puede disparar flechas en pleno salto o ejecutar un Dash horizontal mientras cae.

\subsubsection*{Principios de respuesta}

Los comandos se leen a través del sistema de entradas en los ciclos \texttt{Update()} para detectar pulsaciones de botones instantáneas y se ejecutan en \texttt{FixedUpdate()} para aplicar fuerzas físicas consistentes al personaje. No se introduce retraso artificial (\emph{input lag}) en el movimiento, permitiendo que la esquiva con el Dash y los saltos se perciban inmediatos y responsivos.
