using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GateSchemeLogicController : inkWidgetLogicController
	{
		private SoundFxFactsSet _sfxFactsSet;
		private inkWidgetReference _tube1;
		private inkWidgetReference _tube2;
		private inkWidgetReference _tube3;
		private inkWidgetReference _tube4;
		private inkWidgetReference _tube5;
		private inkWidgetReference _tube6;
		private inkWidgetReference _tube7;
		private inkWidgetReference _tube8;
		private CName _openingGateLeftAnimName;
		private CName _openingGateRightAnimName;
		private CInt32 _currentSystemIndex;
		private ScriptGameInstance _gameInstance;

		[Ordinal(1)] 
		[RED("sfxFactsSet")] 
		public SoundFxFactsSet SfxFactsSet
		{
			get => GetProperty(ref _sfxFactsSet);
			set => SetProperty(ref _sfxFactsSet, value);
		}

		[Ordinal(2)] 
		[RED("tube1")] 
		public inkWidgetReference Tube1
		{
			get => GetProperty(ref _tube1);
			set => SetProperty(ref _tube1, value);
		}

		[Ordinal(3)] 
		[RED("tube2")] 
		public inkWidgetReference Tube2
		{
			get => GetProperty(ref _tube2);
			set => SetProperty(ref _tube2, value);
		}

		[Ordinal(4)] 
		[RED("tube3")] 
		public inkWidgetReference Tube3
		{
			get => GetProperty(ref _tube3);
			set => SetProperty(ref _tube3, value);
		}

		[Ordinal(5)] 
		[RED("tube4")] 
		public inkWidgetReference Tube4
		{
			get => GetProperty(ref _tube4);
			set => SetProperty(ref _tube4, value);
		}

		[Ordinal(6)] 
		[RED("tube5")] 
		public inkWidgetReference Tube5
		{
			get => GetProperty(ref _tube5);
			set => SetProperty(ref _tube5, value);
		}

		[Ordinal(7)] 
		[RED("tube6")] 
		public inkWidgetReference Tube6
		{
			get => GetProperty(ref _tube6);
			set => SetProperty(ref _tube6, value);
		}

		[Ordinal(8)] 
		[RED("tube7")] 
		public inkWidgetReference Tube7
		{
			get => GetProperty(ref _tube7);
			set => SetProperty(ref _tube7, value);
		}

		[Ordinal(9)] 
		[RED("tube8")] 
		public inkWidgetReference Tube8
		{
			get => GetProperty(ref _tube8);
			set => SetProperty(ref _tube8, value);
		}

		[Ordinal(10)] 
		[RED("OpeningGateLeftAnimName")] 
		public CName OpeningGateLeftAnimName
		{
			get => GetProperty(ref _openingGateLeftAnimName);
			set => SetProperty(ref _openingGateLeftAnimName, value);
		}

		[Ordinal(11)] 
		[RED("OpeningGateRightAnimName")] 
		public CName OpeningGateRightAnimName
		{
			get => GetProperty(ref _openingGateRightAnimName);
			set => SetProperty(ref _openingGateRightAnimName, value);
		}

		[Ordinal(12)] 
		[RED("currentSystemIndex")] 
		public CInt32 CurrentSystemIndex
		{
			get => GetProperty(ref _currentSystemIndex);
			set => SetProperty(ref _currentSystemIndex, value);
		}

		[Ordinal(13)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		public GateSchemeLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
