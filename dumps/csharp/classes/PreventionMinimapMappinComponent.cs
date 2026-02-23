using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionMinimapMappinComponent : IScriptable
	{
		private wCHandle<gameuiMinimapStealthMappinController> _minimapStealthMappinController;
		private wCHandle<gameIBlackboard> _uiWantedBarBB;
		private CHandle<UI_WantedBarDef> _uiWantedBarBBDef;
		private CHandle<redCallbackObject> _currentWantedStateCallback;
		private CBool _playerWanted;
		private CBool _playerEscapingPursuit;
		private CFloat _maxVisibilityDistance;

		[Ordinal(0)] 
		[RED("minimapStealthMappinController")] 
		public wCHandle<gameuiMinimapStealthMappinController> MinimapStealthMappinController
		{
			get => GetProperty(ref _minimapStealthMappinController);
			set => SetProperty(ref _minimapStealthMappinController, value);
		}

		[Ordinal(1)] 
		[RED("uiWantedBarBB")] 
		public wCHandle<gameIBlackboard> UiWantedBarBB
		{
			get => GetProperty(ref _uiWantedBarBB);
			set => SetProperty(ref _uiWantedBarBB, value);
		}

		[Ordinal(2)] 
		[RED("uiWantedBarBBDef")] 
		public CHandle<UI_WantedBarDef> UiWantedBarBBDef
		{
			get => GetProperty(ref _uiWantedBarBBDef);
			set => SetProperty(ref _uiWantedBarBBDef, value);
		}

		[Ordinal(3)] 
		[RED("currentWantedStateCallback")] 
		public CHandle<redCallbackObject> CurrentWantedStateCallback
		{
			get => GetProperty(ref _currentWantedStateCallback);
			set => SetProperty(ref _currentWantedStateCallback, value);
		}

		[Ordinal(4)] 
		[RED("playerWanted")] 
		public CBool PlayerWanted
		{
			get => GetProperty(ref _playerWanted);
			set => SetProperty(ref _playerWanted, value);
		}

		[Ordinal(5)] 
		[RED("playerEscapingPursuit")] 
		public CBool PlayerEscapingPursuit
		{
			get => GetProperty(ref _playerEscapingPursuit);
			set => SetProperty(ref _playerEscapingPursuit, value);
		}

		[Ordinal(6)] 
		[RED("maxVisibilityDistance")] 
		public CFloat MaxVisibilityDistance
		{
			get => GetProperty(ref _maxVisibilityDistance);
			set => SetProperty(ref _maxVisibilityDistance, value);
		}

		public PreventionMinimapMappinComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
