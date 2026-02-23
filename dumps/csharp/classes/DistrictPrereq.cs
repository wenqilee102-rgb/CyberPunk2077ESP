using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DistrictPrereq : gameIScriptablePrereq
	{
		private wCHandle<gamedataDistrict_Record> _district;

		[Ordinal(0)] 
		[RED("district")] 
		public wCHandle<gamedataDistrict_Record> District
		{
			get => GetProperty(ref _district);
			set => SetProperty(ref _district, value);
		}

		public DistrictPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
