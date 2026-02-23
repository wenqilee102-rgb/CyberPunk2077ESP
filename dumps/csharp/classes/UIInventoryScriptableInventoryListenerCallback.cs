using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInventoryScriptableInventoryListenerCallback : gameInventoryScriptCallback
	{
		private wCHandle<UIInventoryScriptableSystem> _uiInventoryScriptableSystem;

		[Ordinal(1)] 
		[RED("uiInventoryScriptableSystem")] 
		public wCHandle<UIInventoryScriptableSystem> UiInventoryScriptableSystem
		{
			get => GetProperty(ref _uiInventoryScriptableSystem);
			set => SetProperty(ref _uiInventoryScriptableSystem, value);
		}

		public UIInventoryScriptableInventoryListenerCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
