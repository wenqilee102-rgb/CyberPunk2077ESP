using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerElevationPrereqState : gamePrereqState
	{
		private CFloat _minElevationValue;
		private CFloat _maxElevationValue;
		private CHandle<redCallbackObject> _minElevationListener;
		private CHandle<redCallbackObject> _maxElevationListener;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("minElevationValue")] 
		public CFloat MinElevationValue
		{
			get => GetProperty(ref _minElevationValue);
			set => SetProperty(ref _minElevationValue, value);
		}

		[Ordinal(1)] 
		[RED("maxElevationValue")] 
		public CFloat MaxElevationValue
		{
			get => GetProperty(ref _maxElevationValue);
			set => SetProperty(ref _maxElevationValue, value);
		}

		[Ordinal(2)] 
		[RED("minElevationListener")] 
		public CHandle<redCallbackObject> MinElevationListener
		{
			get => GetProperty(ref _minElevationListener);
			set => SetProperty(ref _minElevationListener, value);
		}

		[Ordinal(3)] 
		[RED("maxElevationListener")] 
		public CHandle<redCallbackObject> MaxElevationListener
		{
			get => GetProperty(ref _maxElevationListener);
			set => SetProperty(ref _maxElevationListener, value);
		}

		[Ordinal(4)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public PlayerElevationPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
