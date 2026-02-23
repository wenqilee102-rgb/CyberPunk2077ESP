using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class District : IScriptable
	{
		private TweakDBID _districtID;
		private TweakDBID _presetID;
		private CHandle<gamedataDistrict_Record> _districtRecord;

		[Ordinal(0)] 
		[RED("districtID")] 
		public TweakDBID DistrictID
		{
			get => GetProperty(ref _districtID);
			set => SetProperty(ref _districtID, value);
		}

		[Ordinal(1)] 
		[RED("presetID")] 
		public TweakDBID PresetID
		{
			get => GetProperty(ref _presetID);
			set => SetProperty(ref _presetID, value);
		}

		[Ordinal(2)] 
		[RED("districtRecord")] 
		public CHandle<gamedataDistrict_Record> DistrictRecord
		{
			get => GetProperty(ref _districtRecord);
			set => SetProperty(ref _districtRecord, value);
		}

		public District(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
