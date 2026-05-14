\subsection{HUD}

\subsubsection*{Diseño general}

El HUD se construye en un \texttt{Canvas} configurado en modo \emph{Scale With Screen Size}. Esta configuración evita deformaciones y permite que la interfaz conserve proporciones adecuadas en diferentes resoluciones de pantalla.

\subsubsection*{Elementos principales}

En la esquina superior izquierda se ubica la información vital del jugador. La salud se representa mediante iconos de corazones usando componentes \texttt{UI Image}, acompañados por un contador numérico cuando sea necesario. Cerca de esta zona se muestra el contador de Diamantes de Almas.

\begin{figure}[hbt!]
    \centering
    \includegraphics[width=0.6\textwidth]{assets/images/items.png} 
    \caption{Vista de la interfaz del jugador mostrando salud y diamantes.}
    \label{fig:ui_elementos_principales}
\end{figure}

\subsubsection*{Textos flotantes de daño}

Cuando un enemigo recibe daño, se instancia un prefab de texto en el espacio del mundo o en un Canvas asociado. Este texto flota hacia arriba y se desvanece progresivamente mediante reducción del valor alfa. La animación puede implementarse con un \texttt{Animator}, una corrutina o un sistema de tweening si el proyecto incorpora una librería externa.

\begin{figure}[H]
    \centering
    \includegraphics[width=0.6\textwidth]{assets/images/dano1.png} 
    \caption{Ejemplo visual de los textos flotantes al infligir daño a un enemigo.}
    \label{fig:textos_flotantes_dano}
\end{figure}

\subsubsection*{Criterios de claridad}

La interfaz debe ser legible sin ocupar espacio excesivo. Los indicadores deben comunicar información esencial y evitar distracciones durante combate o plataformas. La estética debe integrarse con el tono del juego mediante bordes, iconografía y colores coherentes con la fantasía gótica.