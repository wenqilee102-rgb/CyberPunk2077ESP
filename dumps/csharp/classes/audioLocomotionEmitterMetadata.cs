using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioLocomotionEmitterMetadata : audioEmitterMetadata
	{
		private CName _customMaterialLookup;
		private CBool _isPlayer;
		private CName _diveSuitName;

		[Ordinal(1)] 
		[RED("customMaterialLookup")] 
		public CName CustomMaterialLookup
		{
			get => GetProperty(ref _customMaterialLookup);
			set => SetProperty(ref _customMaterialLookup, value);
		}

		[Ordinal(2)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(3)] 
		[RED("diveSuitName")] 
		public CName DiveSuitName
		{
			get => GetProperty(ref _diveSuitName);
			set => SetProperty(ref _diveSuitName, value);
		}

		public audioLocomotionEmitterMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
