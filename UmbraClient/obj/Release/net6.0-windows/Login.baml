   M S B A M L   `   `   `  ���� F  BUmbraClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:UmbraClientUmbraClient  /clr-namespace:MVVM.ViewModelMVVM.ViewModel  G(clr-namespace:UmbraClient.CustomControlsUmbraClient.CustomControls      UmbraClient.Login   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:UmbraClient     2	viewmodelclr-namespace:MVVM.ViewModel     Ccustomcontrols(clr-namespace:UmbraClient.CustomControls     -   $	��460��$	��800��  � WindowStyle$
  None=� � AllowsTransparency$
 True�����#020202���#0e0e0f � 
ResizeMode$ CanResizeWithGrip=� � DataContext "  MVVM.ViewModel.MainViewModel   � 	Resources    BooleanToVisibility��%   &	        �� y���  �� Path$ IsViewVisible� �� Mode$ TwoWay=� �� NotifyOnSourceUpdated$
 True�� �� UpdateSourceTrigger$ PropertyChanged=�	 �� 	Converter#	 [  .��� 
 � RowDefinitions
 �� $��25 ���  � ColumnDefinitions �� .+��� -   $��4�����#020202._�� $��Stretch=�.+��� $��Login�����#fffacd�� $��Right=� �� Orientation$ 
Horizontal=�.+��� -     WindowButtonStyle#��[ $	��＿���� -   #��[ $	��▭���� -     CloseWindowButtonStyle#��[ $	��⨉���� $��2��$	��250��$ Vertical=�$��0 35 0 0q�.+�F�   	IconStyle#��[ ����� �e �� ? � ����H �� �}
S ��43333�S@ ? �e�hffffFW@    �d� �}
�    @���M� `F��?\@N�S��&�����r@gffff�>@������r@gfffff9@�����s@S�T:�����ds@hfffff/@������s@433333(@ f��`*�  � G� �����t@533333@�����!t@533333@�����'t@������@�����,t@������@ ?     @�����1t@     @�����1t@     @�����1t@�@B  ��@��� �� 5 ��Q���- @��ڊ  � $�  ��@�@ ��y� �� ���[<Ӡ4 �������W@�q�������Y@�h�� 4��Wv@�
 � �e �� � �}
� ��/���� :�h�����2?�^C� �� ̿ ����� ���k'��������ŀ@���@�o ��T`��  \�43333��@����@&�" /���# ��    ��@ ���43333��@ ��������@��?�������@� �hffff
�@������~@    ��@�����q~@53333˃@����53333˃@����53333˃@���������Ƀ@����    ȃ@@�������ă@gffff&~@�������@��������̸�@�������̬�@ 8�hffff��@`G���������@��OhffffZ�@��    4�@ ��    �@@D=hffffނ@��hffff@�//��������@`�t53333��@@�S53333��@`m53333��@23333cn@    X�@������d@������{@�����d@63333�{@������d@jffff�{@�,
jffff�{@������e@	$	��128��$	��128���� $��
Umbra Chat��
�������$��28(�$��
#Noto Sans)�$��Center=��� $��W e l c o m e  b a c k .��$��Center=�
���iii�$��0 -5 0 0q��� $ 
Horizontal=�$
��Left=�$��Bottom=�.+�F� #��[ ����� �  �� D�  � �� ��� �  � �� ��� ظ  �� �  ��  �  �� ظ  ��  �  �� B� ���� ��@�;`2�@�� ��K ��`��
 ��gffff&\@ ������M@`2�hffff�H@ ��    `P��    �R���� �`��
 ��43333�p@ ��@I� � ��R� �`P�� ������� ��`�� ��Ѡ/� ��� ��  �����`P�	
�������$��0 9 0 0q�$��12��$��12���� $��	Username:��$��0 12 0 0q��� -    ��Name$ UsernameTextBox��
������ $��13(�$��
#Noto Sans)�
������� �� 
CaretBrush
 �����
�������$��0 0 0 1q�$��28��$��Center=�$��0 5 0 0q����� *
Username+$ TwoWay=�$ PropertyChanged=��� $ 
Horizontal=�$
��Left=�$��Bottom=�.+�F� #��[ ����� �Y ������
 �� D���� D� D�� D� �q� `� �qӠ� �q �`�' � @B� � �� ������ �� `� ��� �� ���43333�<@ ����� ��     @B�    `�'`�� �q �� �q� �� �q� �� D�� �� 1� � �Y�`Y�    ����8 #`���43333�v@`��gffff.v@�a�gffff.u@��q�gffff.t@�C����~�-����@W�@`�`�@ �� �Y ��� @B `�ӠTP `� �*�,	 �* �� �*`��TP � @B �� �q ��`�c
 � h�	`� h�	 �� h�	�,	`�c
 `� �q `�� @B `�	
�������$��0 9 0 0q�$��12��$��12���� $��	Password:��$��0 12 0 0q�4   .UmbraClient.CustomControls.BindablePasswordBox  $��28��$��0 5 0 0q�   Password �� *
Password+$ TwoWay=�$ PropertyChanged=��� -   $��AccessLabel��
��� ���$��9(����� *ErrorMessage+��   LoginButtonStyle#��[ $��Center=�$��0 12 0 0q����� *LoginCommand+