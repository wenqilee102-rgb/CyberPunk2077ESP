using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questUseWeapon_MissileRainGrid_NodeType : questUseWeapon_NodeType
	{
		private CEnum<questEUseWeapon_MissileOffsetsSource> _source;
		private CArray<Vector3> _missileOffsets;
		private CArray<gameEntityReference> _targetRefs;
		private TweakDBID _recordID;

		[Ordinal(5)] 
		[RED("source")] 
		public CEnum<questEUseWeapon_MissileOffsetsSource> Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(6)] 
		[RED("missileOffsets")] 
		public CArray<Vector3> MissileOffsets
		{
			get => GetProperty(ref _missileOffsets);
			set => SetProperty(ref _missileOffsets, value);
		}

		[Ordinal(7)] 
		[RED("targetRefs")] 
		public CArray<gameEntityReference> TargetRefs
		{
			get => GetProperty(ref _targetRefs);
			set => SetProperty(ref _targetRefs, value);
		}

		[Ordinal(8)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}

		public questUseWeapon_MissileRainGrid_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
