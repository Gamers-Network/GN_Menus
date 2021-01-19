using System;
using System.Threading.Tasks;
using PoliceFunctions_API.Functions;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using CitizenFX.Core.UI;
using NativeUI;

namespace GNPolicUniforms
{
    public class MainMenu : BaseScript
    {
        private MenuPool _menuPool;
        private UIMenu mainMenu;
            
        public void PlayerOptions(UIMenu menu)
        {
            var playeroptionssub = _menuPool.AddSubMenu(menu, "Police Uniforms");
            for (int i = 0; i < 1; i++) ;

            playeroptionssub.MouseEdgeEnabled = false;
            playeroptionssub.ControlDisablingEnabled = false;
            
            
            /// Uniforms ///
            var uniforms = _menuPool.AddSubMenu(playeroptionssub, "Police");
            for (int i = 0; i < 1; i++) ;

            uniforms.MouseEdgeEnabled = false;
            uniforms.ControlDisablingEnabled = false;
            
            var lspduniforms = _menuPool.AddSubMenu(uniforms, "LSPD");
            for (int i = 0; i < 1; i++) ;

            lspduniforms.MouseEdgeEnabled = false;
            lspduniforms.ControlDisablingEnabled = false;
            
                        /// Rookie Ped ///
            var cop01 = new UIMenuItem("Rookie", "");
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
            var sheriff01 = new UIMenuItem("Sheriff", "");
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
            var fib = new UIMenuItem("FIB", "");
            fibuniforms.AddItem(fib);
            fibuniforms.OnItemSelect += (sender, item, index) =>
            {
                if (item == fib)
                {
                    Game.Player.ChangeModel("s_m_m_fibsec_01");
                }
            };
            
            var emsfiresub = _menuPool.AddSubMenu(menu, "EMS/Fire");
            for (int i = 0; i < 1; i++) ;

            emsfiresub.MouseEdgeEnabled = false;
            emsfiresub.ControlDisablingEnabled = false;
            
            
            var ems = new UIMenuItem("EMS", "");
            emsfiresub.AddItem(ems);
            emsfiresub.OnItemSelect += (sender, item, index) =>
            {
                if (item == ems)
                {
                   Game.Player.ChangeModel("s_m_y_autopsy_01"); 
                }
            };
           
           var fire = new UIMenuItem("Fire", "");
            emsfiresub.AddItem(fire);
            emsfiresub.OnItemSelect += (sender, item, index) =>
            {
                if (item == fire)
                {
                    Game.Player.ChangeModel("s_m_y_fireman_01");
                }
            };
            
        }  
            
            public MainMenu()
        {
            _menuPool    = new MenuPool();
            var mainMenu = new UIMenu("GN Police Locker", "~b~ Made By ApexDevil");
            _menuPool.Add(mainMenu);
                
            PlayerOptions(mainMenu);

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