   M S B A M L   `   `   `  ����B  >ChatP2P, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ChatP2PChatP2P  5   	       ChatP2P.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ChatP2P     5   	   -   5          � Title$  
MainWindow��5   	   $	��476��6   $	��800��6)   .��5      � .+�5   
   �� $#��Indirizzo Ip del Destinatario��6   $
��Left=�68   $��	35,10,0,0q�6S   $	��Top=�6f   �� 5   
   -   5         ��Name$ TXT_Destinatario��5      $
��Left=�6,   $��
211,14,0,0q�6G    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��120��6�   $��	localhost��6�   �� 5   
   -   5        $ TXT_Messaggio��5      $
��Left=�6)   $��437,332,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $	��296��6�   $��22��6�   �� 5   
   $+��%Scrivere qui il messaggio da inviare:��6   $
��Left=�6@   $��183,325,0,0q�6[   $	��Top=�6p   �� 5   
   -   5         ��Name$ BTTN_Collegamento��5      $��Collagemento��6,   $
��Left=�6C   $��
353,14,0,0q�6^   $	��Top=�6r   $	��131��6�   6�   �� 5   
   -   5        $ 	BTTN_Send��5      $��Invio��6$   $
��Left=�64   $��437,385,0,0q�6O   $	��Top=�6d   $	��296��6|   6�   �� 5   
   -   5        $ BTTN_ChiusuraCollegamento��5      $��Esci Dalla Chat��64   $
��Left=�6N   $��
35,385,0,0q�6i   $	��Top=�6}   $	��296��6�   6�   �� 5   
   -   5         ��Name$ 	TXT_MDest��5      $��Messaggi ricevut:��6#   $
��Left=�6?   $��	35,55,0,0q�6Z   $	��Top=�6m   $	��246��6�   $	��296��6�   �� 5   
   -   5        $ 	TXT_MMitt��5      $��Messaggi inviati:��6#   $
��Left=�6?   $��
437,60,0,0q�6Z   $	��Top=�6n   $	��246��6�   $	��296��6�   �� 5   
   $
��Left=�6   $	��251��6/   $��	35,55,0,0q�6<   
���   �$	��Top=�6^   $	��296��6v   �� 5   
   $
��Left=�6   $	��250��6/   $��
437,58,0,0q�6<   
���   �$	��Top=�6_   $	��296��6w   5      5      