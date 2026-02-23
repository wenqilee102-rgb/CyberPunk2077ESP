using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudSniperNestController : gameuiHUDGameController
	{
		private wCHandle<gameIBlackboard> _psmBlackboard;
		private wCHandle<gameIBlackboard> _tcsBlackboard;
		private CHandle<redCallbackObject> _pSM_BBID;
		private CHandle<redCallbackObject> _tcs_BBID;
		private CHandle<redCallbackObject> _deviceChain_BBID;
		private wCHandle<inkCompoundWidget> _root;
		private wCHandle<gameObject> _controlledObjectRef;
		private CHandle<inkanimDefinition> _alpha_fadein;
		private CHandle<inkanimProxy> _animProxy;
		private inkanimPlaybackOptions _animOptions;
		private wCHandle<gameObject> _ownerObject;
		private CInt32 _maxZoomLevel;

		[Ordinal(9)] 
		[RED("psmBlackboard")] 
		public wCHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetProperty(ref _psmBlackboard);
			set => SetProperty(ref _psmBlackboard, value);
		}

		[Ordinal(10)] 
		[RED("tcsBlackboard")] 
		public wCHandle<gameIBlackboard> TcsBlackboard
		{
			get => GetProperty(ref _tcsBlackboard);
			set => SetProperty(ref _tcsBlackboard, value);
		}

		[Ordinal(11)] 
		[RED("PSM_BBID")] 
		public CHandle<redCallbackObject> PSM_BBID
		{
			get => GetProperty(ref _pSM_BBID);
			set => SetProperty(ref _pSM_BBID, value);
		}

		[Ordinal(12)] 
		[RED("tcs_BBID")] 
		public CHandle<redCallbackObject> Tcs_BBID
		{
			get => GetProperty(ref _tcs_BBID);
			set => SetProperty(ref _tcs_BBID, value);
		}

		[Ordinal(13)] 
		[RED("deviceChain_BBID")] 
		public CHandle<redCallbackObject> DeviceChain_BBID
		{
			get => GetProperty(ref _deviceChain_BBID);
			set => SetProperty(ref _deviceChain_BBID, value);
		}

		[Ordinal(14)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(15)] 
		[RED("controlledObjectRef")] 
		public wCHandle<gameObject> ControlledObjectRef
		{
			get => GetProperty(ref _controlledObjectRef);
			set => SetProperty(ref _controlledObjectRef, value);
		}

		[Ordinal(16)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get => GetProperty(ref _alpha_fadein);
			set => SetProperty(ref _alpha_fadein, value);
		}

		[Ordinal(17)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(18)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetProperty(ref _animOptions);
			set => SetProperty(ref _animOptions, value);
		}

		[Ordinal(19)] 
		[RED("ownerObject")] 
		public wCHandle<gameObject> OwnerObject
		{
			get => GetProperty(ref _ownerObject);
			set => SetProperty(ref _ownerObject, value);
		}

		[Ordinal(20)] 
		[RED("maxZoomLevel")] 
		public CInt32 MaxZoomLevel
		{
			get => GetProperty(ref _maxZoomLevel);
			set => SetProperty(ref _maxZoomLevel, value);
		}

		public hudSniperNestController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
