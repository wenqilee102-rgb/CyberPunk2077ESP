using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HerculesCrosshairtGameController : IronsightGameController
	{
		private CInt32 _appearanceFill;
		private CInt32 _appearanceOutline;
		private CBool _appearanceShowThroughWalls;
		private CFloat _appearanceTransitionTime;
		private CHandle<redCallbackObject> _weaponParamsListenerId;
		private ScriptGameInstance _game;
		private CHandle<gameVisionModeSystem> _visionModeSystem;
		private gameVisionAppearance _targetedApperance;
		private CArray<entEntityID> _targets;

		[Ordinal(63)] 
		[RED("appearanceFill")] 
		public CInt32 AppearanceFill
		{
			get => GetProperty(ref _appearanceFill);
			set => SetProperty(ref _appearanceFill, value);
		}

		[Ordinal(64)] 
		[RED("appearanceOutline")] 
		public CInt32 AppearanceOutline
		{
			get => GetProperty(ref _appearanceOutline);
			set => SetProperty(ref _appearanceOutline, value);
		}

		[Ordinal(65)] 
		[RED("appearanceShowThroughWalls")] 
		public CBool AppearanceShowThroughWalls
		{
			get => GetProperty(ref _appearanceShowThroughWalls);
			set => SetProperty(ref _appearanceShowThroughWalls, value);
		}

		[Ordinal(66)] 
		[RED("appearanceTransitionTime")] 
		public CFloat AppearanceTransitionTime
		{
			get => GetProperty(ref _appearanceTransitionTime);
			set => SetProperty(ref _appearanceTransitionTime, value);
		}

		[Ordinal(67)] 
		[RED("weaponParamsListenerId")] 
		public CHandle<redCallbackObject> WeaponParamsListenerId
		{
			get => GetProperty(ref _weaponParamsListenerId);
			set => SetProperty(ref _weaponParamsListenerId, value);
		}

		[Ordinal(68)] 
		[RED("game")] 
		public ScriptGameInstance Game
		{
			get => GetProperty(ref _game);
			set => SetProperty(ref _game, value);
		}

		[Ordinal(69)] 
		[RED("visionModeSystem")] 
		public CHandle<gameVisionModeSystem> VisionModeSystem
		{
			get => GetProperty(ref _visionModeSystem);
			set => SetProperty(ref _visionModeSystem, value);
		}

		[Ordinal(70)] 
		[RED("targetedApperance")] 
		public gameVisionAppearance TargetedApperance
		{
			get => GetProperty(ref _targetedApperance);
			set => SetProperty(ref _targetedApperance, value);
		}

		[Ordinal(71)] 
		[RED("targets")] 
		public CArray<entEntityID> Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		public HerculesCrosshairtGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
