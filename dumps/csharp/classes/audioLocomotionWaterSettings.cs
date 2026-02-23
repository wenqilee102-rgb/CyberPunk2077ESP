using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioLocomotionWaterSettings : audioAudioMetadata
	{
		private raRef<CResource> _defaultLegVfx;
		private CHandle<audioLocomotionStateVfxDictionary> _locomotionStatesLegVfx;
		private CHandle<audioLocomotionCustomActionVfxDictionary> _customActionLegVfx;
		private CFloat _minSpeedToApplyImpulses;
		private CFloat _minHeelDepthToApplyImpulses;
		private CFloat _shallowWaterDepth;
		private CFloat _intermediateWaterDepth;
		private audioLocomotionWaterContextSettings _shallowSettings;
		private audioLocomotionWaterContextSettings _intermediateSettings;
		private audioLocomotionWaterContextSettings _deepSettings;
		private CFloat _minHeelDepthToSpawnFallFx;
		private CFloat _minDownwardSpeedForRegularFall;
		private CFloat _minDownwardSpeedForFastFall;
		private raRef<CResource> _regularFallVfx;
		private CName _regularFallEvent;
		private raRef<CResource> _fastFallVfx;
		private CName _fastFallEvent;

		[Ordinal(1)] 
		[RED("defaultLegVfx")] 
		public raRef<CResource> DefaultLegVfx
		{
			get => GetProperty(ref _defaultLegVfx);
			set => SetProperty(ref _defaultLegVfx, value);
		}

		[Ordinal(2)] 
		[RED("locomotionStatesLegVfx")] 
		public CHandle<audioLocomotionStateVfxDictionary> LocomotionStatesLegVfx
		{
			get => GetProperty(ref _locomotionStatesLegVfx);
			set => SetProperty(ref _locomotionStatesLegVfx, value);
		}

		[Ordinal(3)] 
		[RED("customActionLegVfx")] 
		public CHandle<audioLocomotionCustomActionVfxDictionary> CustomActionLegVfx
		{
			get => GetProperty(ref _customActionLegVfx);
			set => SetProperty(ref _customActionLegVfx, value);
		}

		[Ordinal(4)] 
		[RED("minSpeedToApplyImpulses")] 
		public CFloat MinSpeedToApplyImpulses
		{
			get => GetProperty(ref _minSpeedToApplyImpulses);
			set => SetProperty(ref _minSpeedToApplyImpulses, value);
		}

		[Ordinal(5)] 
		[RED("minHeelDepthToApplyImpulses")] 
		public CFloat MinHeelDepthToApplyImpulses
		{
			get => GetProperty(ref _minHeelDepthToApplyImpulses);
			set => SetProperty(ref _minHeelDepthToApplyImpulses, value);
		}

		[Ordinal(6)] 
		[RED("shallowWaterDepth")] 
		public CFloat ShallowWaterDepth
		{
			get => GetProperty(ref _shallowWaterDepth);
			set => SetProperty(ref _shallowWaterDepth, value);
		}

		[Ordinal(7)] 
		[RED("intermediateWaterDepth")] 
		public CFloat IntermediateWaterDepth
		{
			get => GetProperty(ref _intermediateWaterDepth);
			set => SetProperty(ref _intermediateWaterDepth, value);
		}

		[Ordinal(8)] 
		[RED("shallowSettings")] 
		public audioLocomotionWaterContextSettings ShallowSettings
		{
			get => GetProperty(ref _shallowSettings);
			set => SetProperty(ref _shallowSettings, value);
		}

		[Ordinal(9)] 
		[RED("intermediateSettings")] 
		public audioLocomotionWaterContextSettings IntermediateSettings
		{
			get => GetProperty(ref _intermediateSettings);
			set => SetProperty(ref _intermediateSettings, value);
		}

		[Ordinal(10)] 
		[RED("deepSettings")] 
		public audioLocomotionWaterContextSettings DeepSettings
		{
			get => GetProperty(ref _deepSettings);
			set => SetProperty(ref _deepSettings, value);
		}

		[Ordinal(11)] 
		[RED("minHeelDepthToSpawnFallFx")] 
		public CFloat MinHeelDepthToSpawnFallFx
		{
			get => GetProperty(ref _minHeelDepthToSpawnFallFx);
			set => SetProperty(ref _minHeelDepthToSpawnFallFx, value);
		}

		[Ordinal(12)] 
		[RED("minDownwardSpeedForRegularFall")] 
		public CFloat MinDownwardSpeedForRegularFall
		{
			get => GetProperty(ref _minDownwardSpeedForRegularFall);
			set => SetProperty(ref _minDownwardSpeedForRegularFall, value);
		}

		[Ordinal(13)] 
		[RED("minDownwardSpeedForFastFall")] 
		public CFloat MinDownwardSpeedForFastFall
		{
			get => GetProperty(ref _minDownwardSpeedForFastFall);
			set => SetProperty(ref _minDownwardSpeedForFastFall, value);
		}

		[Ordinal(14)] 
		[RED("regularFallVfx")] 
		public raRef<CResource> RegularFallVfx
		{
			get => GetProperty(ref _regularFallVfx);
			set => SetProperty(ref _regularFallVfx, value);
		}

		[Ordinal(15)] 
		[RED("regularFallEvent")] 
		public CName RegularFallEvent
		{
			get => GetProperty(ref _regularFallEvent);
			set => SetProperty(ref _regularFallEvent, value);
		}

		[Ordinal(16)] 
		[RED("fastFallVfx")] 
		public raRef<CResource> FastFallVfx
		{
			get => GetProperty(ref _fastFallVfx);
			set => SetProperty(ref _fastFallVfx, value);
		}

		[Ordinal(17)] 
		[RED("fastFallEvent")] 
		public CName FastFallEvent
		{
			get => GetProperty(ref _fastFallEvent);
			set => SetProperty(ref _fastFallEvent, value);
		}

		public audioLocomotionWaterSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
