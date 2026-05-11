\section{Arquitectura Tecnica}

\subsection{Patrones de diseno}

El proyecto contempla el uso del patron \emph{Singleton} en controladores globales como \texttt{GameManager}, \texttt{UIManager} y \texttt{CameraShake}. Este patron permite garantizar una unica instancia de sistemas centrales y facilita accesos como \texttt{GameManager.Instance.UpdateScore()}.

No obstante, el uso de singletons debe mantenerse controlado para evitar acoplamiento excesivo. Los sistemas especificos, como enemigos, proyectiles o recolectables, deben comunicarse mediante referencias claras, eventos o interfaces cuando sea conveniente.

\subsection{Componentes principales}

\textbf{PlayerController.} Gestiona movimiento, salto, lectura de entrada y estados basicos del jugador.

\textbf{CombatController.} Administra ataques cuerpo a cuerpo, proyectiles, tiempos de recuperacion y consumo de energia.

\textbf{HealthSystem.} Controla salud, dano, muerte e invulnerabilidad temporal.

\textbf{EnemyAI.} Implementa estados de patrulla, persecucion, ataque y muerte.

\textbf{UIManager.} Actualiza HUD, menus, contadores y estados de pantalla.

\textbf{GameManager.} Administra progreso global, pausa, reinicio, guardado temporal y transiciones.

\subsection{Flujo de datos}

El flujo recomendado prioriza una comunicacion clara entre sistemas. El jugador recolecta Diamantes de Almas, el sistema de inventario o GameManager actualiza la cantidad disponible, y el UIManager refleja el cambio en pantalla. Del mismo modo, cuando un enemigo recibe dano, su HealthSystem procesa el impacto, instancia retroalimentacion visual y notifica la entrega de recompensa al morir.

\subsection{Consideraciones de rendimiento}

La arquitectura debe evitar instanciaciones excesivas durante momentos de combate intenso. Si las pruebas evidencian caidas de FPS, los proyectiles, textos flotantes y efectos recurrentes deben migrarse a un sistema de \emph{Object Pooling}.

