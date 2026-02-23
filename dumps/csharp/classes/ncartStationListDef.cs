using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ncartStationListDef : CVariable
	{
		private CEnum<ENcartStations> _station;

		[Ordinal(0)] 
		[RED("station")] 
		public CEnum<ENcartStations> Station
		{
			get => GetProperty(ref _station);
			set => SetProperty(ref _station, value);
		}

		public ncartStationListDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
