using System;
using System.Threading.Tasks;
using PoliceFunctions_API.Functions;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using CitizenFX.Core.UI;
using NativeUI;

namespace GNPoliceMenu
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
            var mainMenu = new UIMenu("GN Police Closet", "Made By ~b~GN_ApexDevil v0.0.4");
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