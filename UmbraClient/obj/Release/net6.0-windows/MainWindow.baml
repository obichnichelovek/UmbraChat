   M S B A M L   `   `   `  ���� F  BUmbraClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MVVM.ViewModelMVVM.ViewModel      UmbraClient.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  ,	viewmodelclr-namespace:MVVM.ViewModel  -   $	��640��$
��1200��  � WindowStyle$
  None=� � AllowsTransparency$
 True�����#020202���#0e0e0f � 
ResizeMode$ CanResizeWithGrip=� � DataContext "  MVVM.ViewModel.MainViewModel  *  $Microsoft.Xaml.Behaviors.Interaction   Triggers +  %Microsoft.Xaml.Behaviors.EventTrigger     	EventName$ Loaded��*  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     CommandParameter ��    Command �� *ConnectToServerCommand+.��� -   $��MainGrid��	 � ColumnDefinitions	 �� $	��200 ��� 
 � RowDefinitions
 �� $��25 ��� .+��� -   $��2�����#020202._�� $��Stretch=�.+��� $��
Umbra Chat�����#fffacd�� $��Right=� �� Orientation$ 
Horizontal=�.+��� -      WindowButtonStyle#��[  $	��＿���� -   #��[  $	��▭���� -     CloseWindowButtonStyle#��[ $	��⨉��� $��1�����#0c0c0c
 �� $��48 ��� �� $��62 �.+��� $��Contacts��$��Center=�$��8 0 0 0q��� $��1��
������ $��0 0 0 0q����#0f0f0f  ContactListViewItemsStyle#��[ ���� *
Contacts+ �� SelectedItem �� *SelectedContact+�� $��2��$ 
Horizontal=����#0f0f0f.+���  �� CornerRadius$ 25��$��32��$��32�����#fffacd$��10 0 0 0q��� $��Center=�.+��� $��SemiBold"�$��	0 -5 0 -5q����� *
Username+�� $��online�����#fffacd$��	0 -8 0 -5q�� $��1��$��1��
 �� $��50 ��� �� $��70 �.+��� ���#0c0c0c���#666$��0 0 0 1q�._�� $��Stretch=�$��8q�.+��� $��	@Username��$��5 0 5 0q�$��Center=�$��SemiBold"��� $��Right=�$ 
Horizontal=�.+�F� �����,�	�]w�gffff�c@��[ ��(033333�`� pfffff�?Q`"�gfffff9@Ӡ�� ����� ���    @����� �� � ��Ӏ�� ��@��`��@� �]��@#o����`�`�[��(��%gffffv~@`S��gffffvx@`�M�`�[�6�43333Cv@@�-�Α43333�s@�`Z) <��`"��� b�
�]� D��%[� ���7�	���V�QI	gffffvj@@t*��6`�1Q�,�	43333�8@	$��5 0 5 0q�  	IconStyle#��[ F� �����      ��    `}�`�� �� �� ��� � ��Ӡr- �� `�`}� `�  �� `� `�� `����r- � � �� �� ��43333�<@ ��� `��      ��`0S!���S`��!�����YZ@ U"�����]@ U"  �� U" `�� U"�m�`��!@9<`0S!@��S`� �����z@�<���������q�@������y@43333�z@������u@� ���� �� �� �� �q� �� �l
��T����	������q�@�=� �� ���� �`�`0S!43333�X@	$��5 0 5 0q�#��[ �� -   $��ScrollViewer��$��1��$
��True��$��Disabled=� J� 	AllowDrop$ False��.���� -   $��ChatListView��$
��Auto��$��Stretch=�
������ $��8 0 0 0q�$��0q�  ChatListViewItemsStyle#��[ $��Disabled=����� *SelectedContact.Messages+� $��2��	 �� �� $��90 �.+��� 
������   MessageInputBoxStyle#��[ $��2������ *	Message+�� $ 
Horizontal=�$��Right=�$��1��$��0 0 16 0q�.+�F� ����� �� ��� IJ �� l� �2 l� ظ� l� ��� l� �Q IJ ̿ �� ̿� `� ̿� �i ̿ �� �Q �� ��� �� ظ� �� �2 �i �� `� ��� �� ���     ظ�    `5�`�� H� �� H�� `� H�Ӡ� H� �`5� � ظ� � ��� ��J��� 8� `� 8�� �� 8��43333�<@ 8��J� ���     ظ� �� �� �� v�� 2 v���@P v� �� 1 �� @B� ���Nw�@P 
� 2 
�� �� 
�� �� z
� ����8	�� D� �Y D�� �$ D� .���8	 .� z
� .� 
�� �� 
�� �c 
� ��Nw � @B� � 1 �c v� �� v�� .� v�� .� �� .� �K �$ <� �Y <���� <� �� �K �� �	$��5 5 5 0q�  BigIconStyle#��[ F� ����� g� sU �43333�@�B� `c�43333�8@�e~ �1рխ .�� ��0�43333�{@������!\��w6�_�43333�y@����rgffff�}@� � /~Q�D������\@S@wP������@��z������@�(�
�td�     e@�6 h�	��e h�	 8�� h�	���� h�	��c`K�	�����Ix@@~�	�P������{� ^ Z�gffffu@�W"gffff�t@ ��
�gffffVt@�<k
43333�s@ "e
gffffVs@43333�f@рnQ _�Ѡ����`Vl ���� `Q��C8S l�������Qq@�Z ������p@�����0@@V�Q���������@S��L�fffff�� J ������� g�Zfffff@	$��5 5 16 0q�#��[ 