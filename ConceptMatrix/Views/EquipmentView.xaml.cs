﻿using ConceptMatrix.Models;
using ConceptMatrix.Resx;
using ConceptMatrix.Utility;
using ConceptMatrix.ViewModel;
using ConceptMatrix.Windows;
using MahApps.Metro.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using GearTuple = System.Tuple<int, int, int>;
using WepTuple = System.Tuple<int, int, int, int>;

namespace ConceptMatrix.Views
{
    /// <summary>
    /// Interaction logic for CharacterDetailsView2.xaml
    /// </summary>
    public partial class EquipmentView : UserControl
    {
        public CharacterDetails CharacterDetails { get => (CharacterDetails)BaseViewModel.model; set => BaseViewModel.model = value; }
        public EquipmentView()
        {
            InitializeComponent();
            if (SaveSettings.Default.HasBackground == false) EquipBG.Opacity = 0;
            MainViewModel.equipView = this;
        }

        private void XPos2_V(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            if (XPos2.Value.HasValue)
                MemoryManager.Instance.MemLib.writeMemory(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.WeaponX), "float", XPos2.Value.ToString());
            XPos2.ValueChanged -= XPos2_V;
        }
        private void XPos2_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {
            if (XPos2.IsKeyboardFocusWithin || XPos2.IsMouseOver)
            {
                XPos2.ValueChanged -= XPos2_V;
                XPos2.ValueChanged += XPos2_V;
            }
        }

        private void XPos2_V2(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            if (XPos2_Copy.Value.HasValue)
                MemoryManager.Instance.MemLib.writeMemory(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.WeaponY), "float", XPos2_Copy.Value.ToString());
            XPos2_Copy.ValueChanged -= XPos2_V2;
        }

        private void XPos2_Copy_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {
            if (XPos2_Copy.IsKeyboardFocusWithin || XPos2_Copy.IsMouseOver)
            {
                XPos2_Copy.ValueChanged -= XPos2_V2;
                XPos2_Copy.ValueChanged += XPos2_V2;
            }
        }

        private void XPos2_Copy1v(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            if (XPos2_Copy1.Value.HasValue)
                MemoryManager.Instance.MemLib.writeMemory(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.WeaponZ), "float", XPos2_Copy1.Value.ToString());
            XPos2_Copy1.ValueChanged -= XPos2_Copy1v;
        }

        private void XPos2_Copy1_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {
            if (XPos2_Copy1.IsKeyboardFocusWithin || XPos2_Copy1.IsMouseOver)
            {
                XPos2_Copy1.ValueChanged -= XPos2_Copy1v;
                XPos2_Copy1.ValueChanged += XPos2_Copy1v;
            }
        }

        private void WeaponRedChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            if (WeaponRed.Value.HasValue)
                MemoryManager.Instance.MemLib.writeMemory(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.WeaponRed), "float", WeaponRed.Value.ToString());
            WeaponRed.ValueChanged -= WeaponRedChanged;
        }

        private void WeaponRed_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {
            if (WeaponRed.IsKeyboardFocusWithin || WeaponRed.IsMouseOver)
            {
                WeaponRed.ValueChanged -= WeaponRedChanged;
                WeaponRed.ValueChanged += WeaponRedChanged;
            }
        }

        private void WeaponGreenChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            if (WeaponGreen.Value.HasValue)
                MemoryManager.Instance.MemLib.writeMemory(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.WeaponGreen), "float", WeaponGreen.Value.ToString());
            WeaponGreen.ValueChanged -= WeaponGreenChanged;
        }

        private void WeaponGreen_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {
            if (WeaponGreen.IsKeyboardFocusWithin || WeaponGreen.IsMouseOver)
            {
                WeaponGreen.ValueChanged -= WeaponGreenChanged;
                WeaponGreen.ValueChanged += WeaponGreenChanged;
            }
        }

        private void WeaponBlueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            if (WeaponBlue.Value.HasValue)
                MemoryManager.Instance.MemLib.writeMemory(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.WeaponBlue), "float", WeaponBlue.Value.ToString());
            WeaponBlue.ValueChanged -= WeaponBlueChanged;
        }

        private void WeaponBlue_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {
            if (WeaponBlue.IsKeyboardFocusWithin || WeaponBlue.IsMouseOver)
            {
                WeaponBlue.ValueChanged -= WeaponBlueChanged;
                WeaponBlue.ValueChanged += WeaponBlueChanged;
            }
        }

        private void OXPosChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            if (OXPos.Value.HasValue)
                MemoryManager.Instance.MemLib.writeMemory(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.OffhandX), "float", OXPos.Value.ToString());
            OXPos.ValueChanged -= OXPosChanged;
        }

        private void OXPos_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {
            if (OXPos.IsKeyboardFocusWithin || OXPos.IsMouseOver)
            {
                OXPos.ValueChanged -= OXPosChanged;
                OXPos.ValueChanged += OXPosChanged;
            }
        }

        private void OYPosChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            if (OYPos.Value.HasValue)
                MemoryManager.Instance.MemLib.writeMemory(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.OffhandY), "float", OYPos.Value.ToString());
            OYPos.ValueChanged -= OYPosChanged;
        }

        private void OYPos_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {
            if (OYPos.IsKeyboardFocusWithin || OYPos.IsMouseOver)
            {
                OYPos.ValueChanged -= OYPosChanged;
                OYPos.ValueChanged += OYPosChanged;
            }
        }

        private void OZPosChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            if (OZPos.Value.HasValue)
                MemoryManager.Instance.MemLib.writeMemory(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.OffhandZ), "float", OZPos.Value.ToString());
            OZPos.ValueChanged -= OZPosChanged;
        }

        private void OZPos_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {
            if (OZPos.IsKeyboardFocusWithin || OZPos.IsMouseOver)
            {
                OZPos.ValueChanged -= OZPosChanged;
                OZPos.ValueChanged += OZPosChanged;
            }
        }
        private void OffRedChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            if (OffRed.Value.HasValue)
                MemoryManager.Instance.MemLib.writeMemory(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.OffhandRed), "float", OffRed.Value.ToString());
            OffRed.ValueChanged -= OffRedChanged;
        }
        private void OffRed_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {
            if (OffRed.IsKeyboardFocusWithin || OffRed.IsMouseOver)
            {
                OffRed.ValueChanged -= OffRedChanged;
                OffRed.ValueChanged += OffRedChanged;
            }
        }

        private void OffGChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            if (OffGreen.Value.HasValue)
                MemoryManager.Instance.MemLib.writeMemory(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.OffhandGreen), "float", OffGreen.Value.ToString());
            OffGreen.ValueChanged -= OffGChanged;
        }

        private void OffGreen_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {
            if (OffGreen.IsKeyboardFocusWithin || OffGreen.IsMouseOver)
            {
                OffGreen.ValueChanged -= OffGChanged;
                OffGreen.ValueChanged += OffGChanged;
            }
        }

        private void OffBChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            if (OffBlue.Value.HasValue)
                MemoryManager.Instance.MemLib.writeMemory(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.OffhandBlue), "float", OffBlue.Value.ToString());
            OffBlue.ValueChanged -= OffBChanged;
        }

        private void OffBlue_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {
            if (OffBlue.IsKeyboardFocusWithin || OffBlue.IsMouseOver)
            {
                OffBlue.ValueChanged -= OffBChanged;
                OffBlue.ValueChanged += OffBChanged;
            }
        }
        public static bool CheckItemList()
        {
            if (CharacterDetailsView.dataProvider.Items == null)
            {
                CharacterDetailsView.dataProvider.MakeItemList();
                if (CharacterDetailsView.dataProvider.Items == null)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool CheckPropList()
        {
            if (CharacterDetailsView.dataProvider.ItemsProps == null)
            {
                CharacterDetailsView.dataProvider.MakePropList();
                if (CharacterDetailsView.dataProvider.ItemsProps == null)
                {
                    return false;
                }
            }
            return true;
        }

        public enum ItemCategory : int
        {
            MainHand,
            OffHand,
            Head,
            Body,
            Arms,
            Legs,
            Feet,
            Ears,
            Neck,
            Wrist,
            RightRing,
            LeftRing
        }

        private void EquipmentControlOpen(ExdCsvReader.CMItem[] items, ItemCategory category)
        {
            // Open or close the menu.
            EquipmentControl.IsOpen = !(EquipmentControl.IsOpen && EquipmentControl.CategoryBox.SelectedIndex == (int)category);
            // Select the equip tab.
            EquipmentControl.EquipTab.IsSelected = true;
            // Set the category box.
            EquipmentControl.CategoryBox.SelectedIndex = (int)category;

            // Set the gear for this category.
            EquipmentControl.GearPicker(items);

            // Check included control only visible for main hand and offhand.
            EquipmentControl.CheckIncluded.Visibility =  category == ItemCategory.MainHand || category == ItemCategory.OffHand ? Visibility.Visible : Visibility.Hidden;
            // Set the check included label based on MH/OH, other values don't matter because it will be invisible.
            EquipmentControl.CheckIncluded.Content = category == ItemCategory.MainHand ? FlyOutStrings.IncludeOffhand : FlyOutStrings.NoneOffHand;
            // Turn on the class list filtering.
            EquipmentControl.ClassBox.Visibility = Visibility.Visible;
            // Enable the currently equipped prefix label.
            EquipmentControl.EquippedLabel.Visibility = Visibility.Visible;
            // Enable the currently equipped name.
            EquipmentControl.CurrentlyEquippedName.Visibility = Visibility.Visible;
            // Enable the dyes for equipment that isn't the accessories.
            EquipmentControl.KeepDyes.Visibility = category < ItemCategory.Ears ? Visibility.Visible : Visibility.Hidden;
        }

        private void MainSearch_Click(object sender, RoutedEventArgs e) =>
            EquipmentControlOpen(CharacterDetailsView.dataProvider.Items.ToArray().Where(c => c.Type == ExdCsvReader.ItemType.Wep || c.Type == ExdCsvReader.ItemType.Shield).ToArray(), ItemCategory.MainHand);

        private void OffSearch_Click(object sender, RoutedEventArgs e) =>
            EquipmentControlOpen(CharacterDetailsView.dataProvider.Items.ToArray().Where(c => c.Type == ExdCsvReader.ItemType.Wep || c.Type == ExdCsvReader.ItemType.Shield).ToArray(), ItemCategory.OffHand);

        private void HeadSearch_Click(object sender, RoutedEventArgs e) =>
            EquipmentControlOpen(CharacterDetailsView.dataProvider.Items.ToArray().Where(c => c.Type == ExdCsvReader.ItemType.Head).ToArray(), ItemCategory.Head);

        private void BodySearch_Click(object sender, RoutedEventArgs e) =>
            EquipmentControlOpen(CharacterDetailsView.dataProvider.Items.ToArray().Where(c => c.Type == ExdCsvReader.ItemType.Body).ToArray(), ItemCategory.Body);

        private void HandSearch_Click(object sender, RoutedEventArgs e) =>
            EquipmentControlOpen(CharacterDetailsView.dataProvider.Items.ToArray().Where(c => c.Type == ExdCsvReader.ItemType.Hands).ToArray(), ItemCategory.Arms);

        private void LegsSearch_Click(object sender, RoutedEventArgs e) =>
            EquipmentControlOpen(CharacterDetailsView.dataProvider.Items.ToArray().Where(c => c.Type == ExdCsvReader.ItemType.Legs).ToArray(), ItemCategory.Legs);

        private void FeetSearch_Click(object sender, RoutedEventArgs e) =>
            EquipmentControlOpen(CharacterDetailsView.dataProvider.Items.ToArray().Where(c => c.Type == ExdCsvReader.ItemType.Feet).ToArray(), ItemCategory.Feet);

        private void EarSearch_Click(object sender, RoutedEventArgs e) =>
            EquipmentControlOpen(CharacterDetailsView.dataProvider.Items.ToArray().Where(c => c.Type == ExdCsvReader.ItemType.Ears).ToArray(), ItemCategory.Ears);

        private void NeckSearch_Click(object sender, RoutedEventArgs e) =>
            EquipmentControlOpen(CharacterDetailsView.dataProvider.Items.ToArray().Where(c => c.Type == ExdCsvReader.ItemType.Neck).ToArray(), ItemCategory.Neck);

        private void WristSearch_Click(object sender, RoutedEventArgs e) =>
            EquipmentControlOpen(CharacterDetailsView.dataProvider.Items.ToArray().Where(c => c.Type == ExdCsvReader.ItemType.Wrists).ToArray(), ItemCategory.Wrist);

        private void RightSearch_Click(object sender, RoutedEventArgs e) =>
            EquipmentControlOpen(CharacterDetailsView.dataProvider.Items.ToArray().Where(c => c.Type == ExdCsvReader.ItemType.Ring).ToArray(), ItemCategory.RightRing);

        private void LeftSearch_Click(object sender, RoutedEventArgs e) =>
            EquipmentControlOpen(CharacterDetailsView.dataProvider.Items.ToArray().Where(c => c.Type == ExdCsvReader.ItemType.Ring).ToArray(), ItemCategory.LeftRing);

        public static bool CheckResidentList()
        {
            if (CharacterDetailsView.dataProvider.Residents == null)
            {
                CharacterDetailsView.dataProvider.MakeResidentList();
                if (CharacterDetailsView.dataProvider.Residents == null)
                    return false;
            }
            return true;
        }
        private void NPC_Click2(object sender, RoutedEventArgs e)
        {
            if (!CheckResidentList())
                return;
            if (EquipmentControl.IsOpen)
            {
                if (!EquipmentControl.NPCTab.IsSelected)
                {
                    EquipmentControl.NPCTab.IsSelected = true;
                    EquipmentControl.CurrentlyEquippedName.Visibility = Visibility.Hidden;
                    EquipmentControl.EquippedLabel.Visibility = Visibility.Hidden;
                    EquipmentControl.ClassBox.Visibility = Visibility.Hidden;
                    if (!EquipmentFlyOut.UserDoneInteraction) EquipmentControl.ResidentSelector(CharacterDetailsView.dataProvider.Residents.Values.Where(c => c.IsGoodNpc()).ToArray());
                }
                else EquipmentControl.IsOpen = !EquipmentControl.IsOpen;
            }
            else
            {
                EquipmentControl.IsOpen = !EquipmentControl.IsOpen;
                EquipmentControl.NPCTab.IsSelected = true;
                EquipmentControl.CurrentlyEquippedName.Visibility = Visibility.Hidden;
                EquipmentControl.EquippedLabel.Visibility = Visibility.Hidden;
                EquipmentControl.ClassBox.Visibility = Visibility.Hidden;
                if (!EquipmentFlyOut.UserDoneInteraction) EquipmentControl.ResidentSelector(CharacterDetailsView.dataProvider.Residents.Values.Where(c => c.IsGoodNpc()).ToArray());
            }
        }
        private void DigitCheckInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }

        private void PropSearch_Click(object sender, RoutedEventArgs e)
        {
           if (!CheckPropList())
                return;
            if (EquipmentControl.IsOpen)
            {
                if (!EquipmentControl.EquipTab.IsSelected || EquipmentControl.CategoryBox.SelectedIndex != 12)
                {
                    EquipmentControl.EquipTab.IsSelected = true;
                    EquipmentControl.CategoryBox.SelectedIndex = 12;
                    EquipmentControl.CheckIncluded.Visibility = Visibility.Hidden;
                    EquipmentControl.KeepDyes.Visibility = Visibility.Hidden;
                    EquipmentControl.CurrentlyEquippedName.Visibility = Visibility.Hidden;
                    EquipmentControl.EquippedLabel.Visibility = Visibility.Hidden;
                    EquipmentControl.ClassBox.Visibility = Visibility.Hidden;
                    EquipmentControl.GearPicker(CharacterDetailsView.dataProvider.ItemsProps.ToArray());
                }
                else EquipmentControl.IsOpen = !EquipmentControl.IsOpen;
            }
            else
            {
                EquipmentControl.IsOpen = !EquipmentControl.IsOpen;
                EquipmentControl.CategoryBox.SelectedIndex = 12;
                EquipmentControl.EquipTab.IsSelected = true;
                EquipmentControl.CheckIncluded.Visibility = Visibility.Hidden;
                EquipmentControl.KeepDyes.Visibility = Visibility.Hidden;
                EquipmentControl.CurrentlyEquippedName.Visibility = Visibility.Hidden;
                EquipmentControl.EquippedLabel.Visibility = Visibility.Hidden;
                EquipmentControl.ClassBox.Visibility = Visibility.Hidden;
                EquipmentControl.GearPicker(CharacterDetailsView.dataProvider.ItemsProps.ToArray());
            }
        }

        private void PropSearchOH_Click(object sender, RoutedEventArgs e)
        {
            if (!CheckPropList())
                return;
            if (EquipmentControl.IsOpen)
            {
                if (!EquipmentControl.EquipTab.IsSelected || EquipmentControl.CategoryBox.SelectedIndex != 13)
                {
                    EquipmentControl.EquipTab.IsSelected = true;
                    EquipmentControl.CategoryBox.SelectedIndex = 13;
                    EquipmentControl.CheckIncluded.Visibility = Visibility.Hidden;
                    EquipmentControl.CurrentlyEquippedName.Visibility = Visibility.Hidden;
                    EquipmentControl.EquippedLabel.Visibility = Visibility.Hidden;
                    EquipmentControl.ClassBox.Visibility = Visibility.Hidden;
                    EquipmentControl.GearPicker(CharacterDetailsView.dataProvider.ItemsProps.ToArray());
                }
                else EquipmentControl.IsOpen = !EquipmentControl.IsOpen;
            }
            else
            {
                EquipmentControl.IsOpen = !EquipmentControl.IsOpen;
                EquipmentControl.CategoryBox.SelectedIndex = 13;
                EquipmentControl.EquipTab.IsSelected = true;
                EquipmentControl.CheckIncluded.Visibility = Visibility.Hidden;
                EquipmentControl.CurrentlyEquippedName.Visibility = Visibility.Hidden;
                EquipmentControl.EquippedLabel.Visibility = Visibility.Hidden;
                EquipmentControl.ClassBox.Visibility = Visibility.Hidden;
                EquipmentControl.GearPicker(CharacterDetailsView.dataProvider.ItemsProps.ToArray());
            }
        }
        private void SaveGearset_Click(object sender, RoutedEventArgs e)
        {
            var c = new Windows.GearSave("Save Gearset", "Write Gearset name here...");
            c.Owner = Application.Current.MainWindow;
            c.ShowDialog();
            if (c.Filename == null) return;
            else
            {
                string path = SaveSettings.Default.GearsetsDirectory;
                if (!Directory.Exists(path)) System.IO.Directory.CreateDirectory(path);
                GearSaves Save1 = new GearSaves(); // Gearsave is class with all address
                c.Filename = c.Filename.Replace(@"\", " ");
                c.Filename = c.Filename.Replace(@"/", " ");
                Save1.Description = c.Filename;
                Save1.DateCreated = DateTime.Now.ToString("yyyy-MM-dd HH':'mm':'ss");
                Save1.MainHand = new WepTuple(CharacterDetails.Job.value, CharacterDetails.WeaponBase.value, CharacterDetails.WeaponV.value, CharacterDetails.WeaponDye.value);
                Save1.OffHand = new WepTuple(CharacterDetails.Offhand.value, CharacterDetails.OffhandBase.value, CharacterDetails.OffhandV.value, CharacterDetails.OffhandDye.value);
                Save1.EquipmentBytes = CharacterDetails.TestArray2.value;
                string details = JsonConvert.SerializeObject(Save1, Formatting.Indented);
                File.WriteAllText(Path.Combine(path, c.Filename + ".json"), details);
            }
        }

        private void LoadGearSet_Click(object sender, RoutedEventArgs e)
        {
            Windows.GearsetChooseWindow fam = new Windows.GearsetChooseWindow("Select the saved gearset you want to load.");
            fam.Owner = Application.Current.MainWindow;
            fam.ShowDialog();
            if (fam.Choice != null)
            {
                EAoB(fam.Choice);
            }
            else return;
        }
        private void EAoB(GearSaves equpmentarray)
        {
            try
            {
                LoadGearSet.IsEnabled = false;
                byte[] EquipmentArray;
                EquipmentArray = MemoryManager.StringToByteArray(equpmentarray.EquipmentBytes.Replace(" ", string.Empty));
                if (EquipmentArray == null) return;
                CharacterDetails.Offhand.freeze = true;
                CharacterDetails.Job.freeze = true;
                CharacterDetails.HeadPiece.freeze = true;
                CharacterDetails.Chest.freeze = true;
                CharacterDetails.Arms.freeze = true;
                CharacterDetails.Legs.freeze = true;
                CharacterDetails.Feet.freeze = true;
                CharacterDetails.Ear.freeze = true;
                CharacterDetails.Neck.freeze = true;
                CharacterDetails.Wrist.freeze = true;
                CharacterDetails.RFinger.freeze = true;
                CharacterDetails.LFinger.freeze = true;
                System.Threading.Tasks.Task.Delay(25).Wait();
                CharacterDetails.HeadPiece.value = (EquipmentArray[0] + EquipmentArray[1] * 256);
                CharacterDetails.HeadV.value = EquipmentArray[2];
                CharacterDetails.HeadDye.value = EquipmentArray[3];
                CharacterDetails.Chest.value = (EquipmentArray[4] + EquipmentArray[5] * 256);
                CharacterDetails.ChestV.value = EquipmentArray[6];
                CharacterDetails.ChestDye.value = EquipmentArray[7];
                CharacterDetails.Arms.value = (EquipmentArray[8] + EquipmentArray[9] * 256);
                CharacterDetails.ArmsV.value = EquipmentArray[10];
                CharacterDetails.ArmsDye.value = EquipmentArray[11];
                CharacterDetails.Legs.value = (EquipmentArray[12] + EquipmentArray[13] * 256);
                CharacterDetails.LegsV.value = EquipmentArray[14];
                CharacterDetails.LegsDye.value = EquipmentArray[15];
                CharacterDetails.Feet.value = (EquipmentArray[16] + EquipmentArray[17] * 256);
                CharacterDetails.FeetVa.value = EquipmentArray[18];
                CharacterDetails.FeetDye.value = EquipmentArray[19];
                CharacterDetails.Ear.value = (EquipmentArray[20] + EquipmentArray[21] * 256);
                CharacterDetails.EarVa.value = EquipmentArray[22];
                CharacterDetails.Neck.value = (EquipmentArray[24] + EquipmentArray[25] * 256);
                CharacterDetails.NeckVa.value = EquipmentArray[26];
                CharacterDetails.Wrist.value = (EquipmentArray[28] + EquipmentArray[29] * 256);
                CharacterDetails.WristVa.value = EquipmentArray[30];
                CharacterDetails.RFinger.value = (EquipmentArray[32] + EquipmentArray[33] * 256);
                CharacterDetails.RFingerVa.value = EquipmentArray[34];
                CharacterDetails.LFinger.value = (EquipmentArray[36] + EquipmentArray[37] * 256);
                CharacterDetails.LFingerVa.value = EquipmentArray[38];
                MemoryManager.Instance.MemLib.writeBytes(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.HeadPiece), EquipmentArray);
                CharacterDetails.Job.value = equpmentarray.MainHand.Item1;
                CharacterDetails.WeaponV.value = (byte)equpmentarray.MainHand.Item3;
                CharacterDetails.WeaponDye.value = (byte)equpmentarray.MainHand.Item4;
                CharacterDetails.WeaponBase.value = equpmentarray.MainHand.Item2;
                MemoryManager.Instance.MemLib.writeBytes(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.Job), EquipmentFlyOut.WepTupleToByteAry(equpmentarray.MainHand));
                CharacterDetails.Offhand.value = equpmentarray.OffHand.Item1;
                CharacterDetails.OffhandV.value = (byte)equpmentarray.OffHand.Item3;
                CharacterDetails.OffhandDye.value = (byte)equpmentarray.OffHand.Item4;
                CharacterDetails.OffhandBase.value = equpmentarray.OffHand.Item2;
                MemoryManager.Instance.MemLib.writeBytes(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.Offhand), EquipmentFlyOut.WepTupleToByteAry(equpmentarray.OffHand));
                LoadGearSet.IsEnabled = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show("One or more fields were not formatted correctly.\n\n" + exc, " Error " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version, MessageBoxButton.OK, MessageBoxImage.Error);
                LoadGearSet.IsEnabled = true;
            }
        }

        private void SettoZero2_Click(object sender, RoutedEventArgs e)
        {
            CharacterDetails.OffhandX.value = 0;
            MemoryManager.Instance.MemLib.writeMemory(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.OffhandX), "float", "0");
            CharacterDetails.OffhandY.value = 0;
            MemoryManager.Instance.MemLib.writeMemory(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.OffhandY), "float", "0");
            CharacterDetails.OffhandZ.value = 0;
            MemoryManager.Instance.MemLib.writeMemory(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.OffhandZ), "float", "0");
        }

        private void SettoZero_Click(object sender, RoutedEventArgs e)
        {
            CharacterDetails.WeaponX.value = 0;
            MemoryManager.Instance.MemLib.writeMemory(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.WeaponX), "float", "0");
            CharacterDetails.WeaponY.value = 0;
            MemoryManager.Instance.MemLib.writeMemory(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.WeaponY), "float", "0");
            CharacterDetails.WeaponZ.value = 0;
            MemoryManager.Instance.MemLib.writeMemory(MemoryManager.GetAddressString(CharacterDetailsViewModel.baseAddr, Settings.Instance.Character.WeaponZ), "float", "0");
        }

        private void MainHandChangedEventHandler(object sender, TextChangedEventArgs e)
        {
            TextBox mainhandBox = sender as TextBox;
            if (mainhandBox.Text == "0")
            {
                CharacterDetails.WeaponV.value = 0;
                CharacterDetails.Job.value = 0;
            }
        }
    }
}