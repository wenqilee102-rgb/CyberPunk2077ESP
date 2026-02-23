using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFootwearVsMaterialVfxMetadata : audioAudioMetadata
	{
		private CName _footwearType;
		private raRef<CResource> _defaultVfx;
		private CHandle<audioLocomotionStateVfxDictionary> _locomotionStates;
		private CHandle<audioLocomotionCustomActionVfxDictionary> _customActionVfx;

		[Ordinal(1)] 
		[RED("footwearType")] 
		public CName FootwearType
		{
			get => GetProperty(ref _footwearType);
			set => SetProperty(ref _footwearType, value);
		}

		[Ordinal(2)] 
		[RED("defaultVfx")] 
		public raRef<CResource> DefaultVfx
		{
			get => GetProperty(ref _defaultVfx);
			set => SetProperty(ref _defaultVfx, value);
		}

		[Ordinal(3)] 
		[RED("locomotionStates")] 
		public CHandle<audioLocomotionStateVfxDictionary> LocomotionStates
		{
			get => GetProperty(ref _locomotionStates);
			set => SetProperty(ref _locomotionStates, value);
		}

		[Ordinal(4)] 
		[RED("customActionVfx")] 
		public CHandle<audioLocomotionCustomActionVfxDictionary> CustomActionVfx
		{
			get => GetProperty(ref _customActionVfx);
			set => SetProperty(ref _customActionVfx, value);
		}

		public audioFootwearVsMaterialVfxMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
