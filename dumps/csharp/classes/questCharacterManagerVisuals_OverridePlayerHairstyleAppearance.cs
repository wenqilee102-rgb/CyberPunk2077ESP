using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerVisuals_OverridePlayerHairstyleAppearance : questICharacterManagerVisuals_NodeSubType
	{
		private CUInt32 _hairstyleIndex;
		private CName _hairstyleDefinitionName;
		private CUInt32 _beardIndex;
		private CUInt32 _beardPartIndex;
		private CName _beardDefinitionName;

		[Ordinal(0)] 
		[RED("hairstyleIndex")] 
		public CUInt32 HairstyleIndex
		{
			get => GetProperty(ref _hairstyleIndex);
			set => SetProperty(ref _hairstyleIndex, value);
		}

		[Ordinal(1)] 
		[RED("hairstyleDefinitionName")] 
		public CName HairstyleDefinitionName
		{
			get => GetProperty(ref _hairstyleDefinitionName);
			set => SetProperty(ref _hairstyleDefinitionName, value);
		}

		[Ordinal(2)] 
		[RED("beardIndex")] 
		public CUInt32 BeardIndex
		{
			get => GetProperty(ref _beardIndex);
			set => SetProperty(ref _beardIndex, value);
		}

		[Ordinal(3)] 
		[RED("beardPartIndex")] 
		public CUInt32 BeardPartIndex
		{
			get => GetProperty(ref _beardPartIndex);
			set => SetProperty(ref _beardPartIndex, value);
		}

		[Ordinal(4)] 
		[RED("beardDefinitionName")] 
		public CName BeardDefinitionName
		{
			get => GetProperty(ref _beardDefinitionName);
			set => SetProperty(ref _beardDefinitionName, value);
		}

		public questCharacterManagerVisuals_OverridePlayerHairstyleAppearance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
