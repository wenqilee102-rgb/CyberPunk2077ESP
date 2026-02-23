using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CarHotkeyController : GenericHotkeyController
	{
		private inkImageWidgetReference _carIconSlot;
		private wCHandle<gameIBlackboard> _psmBB;
		private wCHandle<gameIBlackboard> _qsdBB;
		private CHandle<redCallbackObject> _bbListener;
		private CHandle<redCallbackObject> _radialListener;

		[Ordinal(25)] 
		[RED("carIconSlot")] 
		public inkImageWidgetReference CarIconSlot
		{
			get => GetProperty(ref _carIconSlot);
			set => SetProperty(ref _carIconSlot, value);
		}

		[Ordinal(26)] 
		[RED("psmBB")] 
		public wCHandle<gameIBlackboard> PsmBB
		{
			get => GetProperty(ref _psmBB);
			set => SetProperty(ref _psmBB, value);
		}

		[Ordinal(27)] 
		[RED("qsdBB")] 
		public wCHandle<gameIBlackboard> QsdBB
		{
			get => GetProperty(ref _qsdBB);
			set => SetProperty(ref _qsdBB, value);
		}

		[Ordinal(28)] 
		[RED("bbListener")] 
		public CHandle<redCallbackObject> BbListener
		{
			get => GetProperty(ref _bbListener);
			set => SetProperty(ref _bbListener, value);
		}

		[Ordinal(29)] 
		[RED("radialListener")] 
		public CHandle<redCallbackObject> RadialListener
		{
			get => GetProperty(ref _radialListener);
			set => SetProperty(ref _radialListener, value);
		}

		public CarHotkeyController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
