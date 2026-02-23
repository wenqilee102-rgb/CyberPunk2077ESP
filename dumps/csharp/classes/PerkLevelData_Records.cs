using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkLevelData_Records : BasePerkLevelData_Records
	{
		private CArray<wCHandle<gamedataPerkLevelData_Record>> _arr;

		[Ordinal(0)] 
		[RED("arr")] 
		public CArray<wCHandle<gamedataPerkLevelData_Record>> Arr
		{
			get => GetProperty(ref _arr);
			set => SetProperty(ref _arr, value);
		}

		public PerkLevelData_Records(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
