using System;
using System.Threading.Tasks;
using PoliceFunctions_API.Functions;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using CitizenFX.Core.UI;
using NativeUI;

namespace PROJECTNAME
{
    public class MainMenu : BaseScript
    {
        private MenuPool _menuPool;
        private UIMenu mainMenu;
            
        
        ///Player Options///
        public void PlayerOptions(UIMenu menu)
        {
            var playeroptionssub = _menuPool.AddSubMenu(menu, "Player Options");
            for (int i = 0; i < 1; i++) ;

            playeroptionssub.MouseEdgeEnabled = false;
            playeroptionssub.ControlDisablingEnabled = false;
            
            
            /// Uniforms ///
            var uniforms = _menuPool.AddSubMenu(playeroptionssub, "Uniforms");
            for (int i = 0; i < 1; i++) ;

            uniforms.MouseEdgeEnabled = false;
            uniforms.ControlDisablingEnabled = false;
            
            var lspduniforms = _menuPool.AddSubMenu(uniforms, "LSPD");
            for (int i = 0; i < 1; i++) ;

            lspduniforms.MouseEdgeEnabled = false;
            lspduniforms.ControlDisablingEnabled = false;
            
                        /// Rookie Ped ///
            var cop01 = new UIMenuItem("Rookie", "PlaceHolder");
            lspduniforms.AddItem(cop01);
            lspduniforms.OnItemSelect += (sender, item, index) =>
            {
                if (item == cop01)
                {
                    Game.Player.ChangeModel("s_m_y_cop_01");
                }
            };
            
            
            var sheriffuniforms = _menuPool.AddSubMenu(uniforms, "Sheriff");
            for (int i = 0; i < 1; i++) ;

            sheriffuniforms.MouseEdgeEnabled = false;
            sheriffuniforms.ControlDisablingEnabled = false;
            
            
                        /// Sheriff Ped ///
            var sheriff01 = new UIMenuItem("Sheriff", "PlaceHolder");
            sheriffuniforms.AddItem(sheriff01);
            sheriffuniforms.OnItemSelect += (sender, item, index) =>
            {
                if (item == sheriff01)
                {
                    Game.Player.ChangeModel("s_m_y_sheriff_01");
                }
            };
            
            
            
            var fibuniforms = _menuPool.AddSubMenu(uniforms, "FIB");
            for (int i = 0; i < 1; i++) ;

            fibuniforms.MouseEdgeEnabled = false;
            fibuniforms.ControlDisablingEnabled = false;
            
            
            /// FIB PED ///    
            var fib = new UIMenuItem("FIB", "PlaceHolder");
            fibuniforms.AddItem(fib);
            fibuniforms.OnItemSelect += (sender, item, index) =>
            {
                if (item == fib)
                {
                    Game.Player.ChangeModel("s_m_m_fibsec_01");
                }
            };
            
        }    
      
        
        /// Police Menu ///
        public void PoliceAPIFunctions(UIMenu menu)
        {
            var policefunctionssub = _menuPool.AddSubMenu(menu, "Police Menu");
            for (int i = 0; i < 1; i++) ;

            policefunctionssub.MouseEdgeEnabled = false;
            policefunctionssub.ControlDisablingEnabled = false;
            
            var available = new UIMenuItem("Go on duty", "");
            policefunctionssub.AddItem(available);
            policefunctionssub.OnItemSelect += (sender, item, index) =>
            {
                if (item == available)
                {
                    API.SetNotificationTextEntry("STRING");
                    API.SetNotificationColorNext(4);
                    API.AddTextComponentString(" ~g~10-4 Stay Safe");
                    API.SetTextScale(0.5f, 0.5f);
                    API.SetNotificationMessage("CHAR_CALL911", "CHAR_CALL911", false, 0, "Dispatch", "Show me ~g~10-8");
                    API.DrawNotification(true, false);
                }
            };
            ///vehicle options menu///
            var vehiclemenusub = _menuPool.AddSubMenu(policefunctionssub, "Vehicle Options");
            for (int i = 0; i < 1; i++) ;

            vehiclemenusub.MouseEdgeEnabled = false;
            vehiclemenusub.ControlDisablingEnabled = false;
            ///vehicle options menu///
            
            
            ///vehicle spawn menu///
            var vehiclespawnsub = _menuPool.AddSubMenu(vehiclemenusub, "Spawn vehicle");
            for (int i = 0; i < 1; i++) ;

            vehiclespawnsub.MouseEdgeEnabled = false;
            vehiclespawnsub.ControlDisablingEnabled = false;
            ///vehicle spawn menu///
            
            
            
            ///vehicle LSPD spawn menu///
            var lspdspawnsub = _menuPool.AddSubMenu(vehiclespawnsub, "LSPD");
            for (int i = 0; i < 1; i++) ;

            vehiclespawnsub.MouseEdgeEnabled = false;
            vehiclespawnsub.ControlDisablingEnabled = false;
            ///vehicle LSPD spawn menu///
            
            
            
            ///vehicle LSPD Cars///
            var police = new UIMenuItem("Spawn Police1", "");
            lspdspawnsub.AddItem(police);
            lspdspawnsub.OnItemSelect += async (sender, item, index) =>
            {
                if (item == police)
                {
                    API.RequestModel((uint)VehicleHash.Police);
                    while (!API.HasModelLoaded((uint)VehicleHash.Police))
                    {
                        await BaseScript.Delay(100);
                    }
                    int Police = API.CreateVehicle((uint)VehicleHash.Police, Game.Player.Character.Position.X, Game.Player.Character.Position.Y, Game.Player.Character.Position.Z, Game.Player.Character.Heading, true, true);
                    API.TaskWarpPedIntoVehicle(Game.Player.Character.Handle, Police, -1);
                    }
            };
            
            var police2 = new UIMenuItem("Spawn Police2", "");
            lspdspawnsub.AddItem(police2);
            lspdspawnsub.OnItemSelect += async (sender, item, index) =>
            {
                if (item == police2)
                {
                    API.RequestModel((uint)VehicleHash.Police2);
                    while (!API.HasModelLoaded((uint)VehicleHash.Police2))
                    {
                        await BaseScript.Delay(100);
                    }
                    int Police2 = API.CreateVehicle((uint)VehicleHash.Police2, Game.Player.Character.Position.X, Game.Player.Character.Position.Y, Game.Player.Character.Position.Z, Game.Player.Character.Heading, true, true);
                    API.TaskWarpPedIntoVehicle(Game.Player.Character.Handle, Police2, -1);
                    }
            };
                    ///vehicle LSPD Cars///
                    
                    
                   /// SAHP Menu /// 
                var sahpspawnsub = _menuPool.AddSubMenu(vehiclespawnsub, "SAHP");
                for (int i = 0; i < 1; i++) ;

                vehiclespawnsub.MouseEdgeEnabled = false;
                vehiclespawnsub.ControlDisablingEnabled = false;
                    
                    
             ///vehicle SAHP Cars///
            var sheriff = new UIMenuItem("Spawn Sheriff", "");
            sahpspawnsub.AddItem(sheriff);
            sahpspawnsub.OnItemSelect += async (sender, item, index) =>
            {
                if (item == sheriff)
                {
                   API.RequestModel((uint)VehicleHash.Sheriff);
                   while (!API.HasModelLoaded((uint)VehicleHash.Sheriff))
                   {
                        await BaseScript.Delay(100);
                   }
                   int Sheriff = API.CreateVehicle((uint)VehicleHash.Sheriff, Game.Player.Character.Position.X, Game.Player.Character.Position.Y, Game.Player.Character.Position.Z, Game.Player.Character.Heading, true, true);
                   API.TaskWarpPedIntoVehicle(Game.Player.Character.Handle, Sheriff, -1);
                }
            
            };
           
            var sheriff2 = new UIMenuItem("Spawn Sheriff2", "");
            sahpspawnsub.AddItem(sheriff2);
            sahpspawnsub.OnItemSelect += async (sender, item, index) =>
            {
                if (item == sheriff2)
                {
                    API.RequestModel((uint)VehicleHash.Sheriff2);
                    while (!API.HasModelLoaded((uint)VehicleHash.Sheriff2))
                    {
                        await BaseScript.Delay(100);
                    }
                    int Sheriff2 = API.CreateVehicle((uint)VehicleHash.Sheriff2, Game.Player.Character.Position.X, Game.Player.Character.Position.Y, Game.Player.Character.Position.Z, Game.Player.Character.Heading, true, true);
                    API.TaskWarpPedIntoVehicle(Game.Player.Character.Handle, Sheriff2, -1);
                }
            };
            
                ///vehicle SAHP Cars///
                
                
                ///Ped options menu///      
            var pedmanager = _menuPool.AddSubMenu(policefunctionssub, "Ped Options");
            for (int i = 0; i < 1; i++) ;

            pedmanager.MouseEdgeEnabled = false;
            pedmanager.ControlDisablingEnabled = false;
            
                
            var stopped = new UIMenuItem("Stop the ped", "");
            pedmanager.AddItem(stopped);
            pedmanager.OnItemSelect += (sender, item, index) =>
            {
                if (item == stopped)
                {
                    PoliceFunctions_API.Functions.PedManager.StopPed();
                }
            };
            
            ///reslease ped ///
            var release = new UIMenuItem("Release Ped", "");
            pedmanager.AddItem(release);
            pedmanager.OnItemSelect += (sender, item, index) =>
            {
                if (item == release)
                {
                    PoliceFunctions_API.Functions.PedManager.ReleasePed();
                    API.SetNotificationTextEntry("STRING");
                    API.SetNotificationColorNext(4);
                    API.AddTextComponentString(" ~g~10-4");
                    API.SetTextScale(0.5f, 0.5f);
                    API.SetNotificationMessage("CHAR_CALL911", "CHAR_CALL911", false, 0, "Dispatch", "Show me ~g~10-8");
                    API.DrawNotification(true, false);
                }
            };
            
            
            /// Ask for ID ///
            var getid = new UIMenuItem("Ask For ID", "");
            pedmanager.AddItem(getid);
            pedmanager.OnItemSelect += (sender, item, index) =>
            {
                if (item == getid)
                {
                    PoliceFunctions_API.Functions.PedManager.GetID();
                }
            };
            
            
            
            /// Check ID /// 
            var checkid = new UIMenuItem("Check ID", "");
            pedmanager.AddItem(checkid);
            pedmanager.OnItemSelect += (sender, item, index) =>
            {
                if (item == checkid)
                {
                    PoliceFunctions_API.Functions.PedManager.CheckID();
                }
            };
            
            var policetools = _menuPool.AddSubMenu(policefunctionssub, "Police Toolbox");
            for (int i = 0; i < 1; i++) ;

            policetools.MouseEdgeEnabled = false;
            policetools.ControlDisablingEnabled = false;
            
            
            /// Breathalyzer ///
            var BreathalyzePed = new UIMenuItem("Breathalyzer", "");
            policetools.AddItem(BreathalyzePed);
            policetools.OnItemSelect += (sender, item, index) =>
            {
                if (item == BreathalyzePed)
                {
                    PoliceFunctions_API.Functions.Tools.BreathalyzePed();
                }
            };
                   
            
            /// Arrest Options menu ///
            var arrestoptions = _menuPool.AddSubMenu(policefunctionssub, "Arrest options");
            for (int i = 0; i < 1; i++) ;

            arrestoptions.MouseEdgeEnabled = false;
            arrestoptions.ControlDisablingEnabled = false;
            
            
            /// Cuff Ped ///
            var cuffped = new UIMenuItem("Cuff Ped", "");
            arrestoptions.AddItem(cuffped);
            arrestoptions.OnItemSelect += (sender, item, index) =>
            {
                if (item == cuffped)
                {
                    PoliceFunctions_API.Functions.Arrest.ArrestPed();
                }
            };
            
            
            
            /// Uncuff & release ///
            var uncuffped = new UIMenuItem("Uncuff&release Ped", "Item description");
            arrestoptions.AddItem(uncuffped);
            arrestoptions.OnItemSelect += (sender, item, index) =>
            {
                if (item == uncuffped)
                {
                   PoliceFunctions_API.Functions.ArrestManager.ReleasePed();
                    API.SetNotificationTextEntry("STRING");
                    API.SetNotificationColorNext(4);
                    API.AddTextComponentString(" ~g~10-4");
                    API.SetTextScale(0.5f, 0.5f);
                    API.SetNotificationMessage("CHAR_CALL911", "CHAR_CALL911", false, 0, "Dispatch", "Show me ~g~10-8");
                    API.DrawNotification(true, false);
                }
            };
           
            
            
           /// Grab Ped ///
           var grabped = new UIMenuItem("Grab Ped", "");
            arrestoptions.AddItem(grabped);
            arrestoptions.OnItemSelect += (sender, item, index) =>
            {
                if (item == grabped)
                {
                   PoliceFunctions_API.Functions.ArrestManager.GrabPed();
                }
            };
           
           
           
           ///Ungrab ped ///
           var ungrabped = new UIMenuItem("ungrab Ped", "");
            arrestoptions.AddItem(ungrabped);
            arrestoptions.OnItemSelect += (sender, item, index) =>
            {
                if (item == ungrabped)
                {
                    PoliceFunctions_API.Functions.ArrestManager.UnDragPed();
                }
            };
            
            
            
            /// Place Ped In Vehicle ///
            var placeinvehicle = new UIMenuItem("Place Ped In Vehicle", "This will place the ped in the rear passenger seat");
            arrestoptions.AddItem(placeinvehicle);
            arrestoptions.OnItemSelect += (sender, item, index) =>
            {
                if (item == placeinvehicle)
                {
                    PoliceFunctions_API.Functions.ArrestManager.SeatRearPassenger();
                }
            };
            
        }
        
        
        /// Service Weapons Menu ///
        public void Weaponslocker(UIMenu menu)
        {
            var weaponssub = _menuPool.AddSubMenu(menu, "Service Weapons");
            for (int i = 0; i < 1; i++) ;

            weaponssub.MouseEdgeEnabled = false;
            weaponssub.ControlDisablingEnabled = false;
            
            
            /// pistol ///
            var pistol = new UIMenuItem("pistol", "");
            weaponssub.AddItem(pistol);
            weaponssub.OnItemSelect += (sender, item, index) =>
            {
                if (item == pistol)
                {
                    Game.Player.Character.Weapons.Give(WeaponHash.CombatPistol, 250, false, true);
                }
            };
            
            
                /// Long Rifle ///
            var rifle = new UIMenuItem("Long Rifle", "");
            weaponssub.AddItem(rifle);
            weaponssub.OnItemSelect += (sender, item, index) =>
            {
                if (item == rifle)
                {
                    Game.Player.Character.Weapons.Give(WeaponHash.CarbineRifle, 400, false, true);
                }
            };
            
            var shotgun = new UIMenuItem("ShotGun", "");
            weaponssub.AddItem(shotgun);
            weaponssub.OnItemSelect += (sender, item, index) =>
            {
                if (item == shotgun)
                {
                    Game.Player.Character.Weapons.Give(WeaponHash.PumpShotgun, 150, false, true);
                }
            };
        }
        
        
        
            /// Discord ///
        public void DiscordLink(UIMenu menu)
        {
            var discord = _menuPool.AddSubMenu(menu, "Discord");
            for (int i = 0; i < 1; i++) ;

            discord.MouseEdgeEnabled = false;
            discord.ControlDisablingEnabled = false;
                
            var invitelink = new UIMenuItem("Invite Link", "");
            discord.AddItem(invitelink);
            discord.OnItemSelect += (sender, item, index) =>
            {
                if (item == invitelink)
                {
                    API.SetNotificationTextEntry("STRING");
                    API.SetNotificationColorNext(4);
                    API.AddTextComponentString("discord.me/gamersnetworkjoin");
                    API.SetTextScale(0.5f, 0.5f);
                    API.SetNotificationMessage("CHAR_SOCIAL_CLUB", "CHAR_SOCIAL_CLUB", false, 0, " ~p~DISCORD", " ~g~Join Here");
                    API.DrawNotification(true, false);
                }
            };
        }
        
        
        
        
        public MainMenu()
        {
            _menuPool    = new MenuPool();
            var mainMenu = new UIMenu("GN Police Menu", "Made By ~b~GN_ApexDevil v0.0.4");
            _menuPool.Add(mainMenu);
                
            PlayerOptions(mainMenu);
            PoliceAPIFunctions(mainMenu);
            Weaponslocker(mainMenu);
            DiscordLink(mainMenu);

            
           
            _menuPool.MouseEdgeEnabled = false;
            _menuPool.ControlDisablingEnabled = false;
            _menuPool.RefreshIndex();

            Tick += async () =>
            {
                _menuPool.ProcessMenus();
                if (API.IsControlJustPressed(0, 166) && !_menuPool.IsAnyMenuOpen()) // Our menu on/off switch
                   mainMenu.Visible = !mainMenu.Visible;
            };
        }
    }
}