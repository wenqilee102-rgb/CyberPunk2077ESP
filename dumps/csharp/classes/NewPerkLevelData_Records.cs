using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerkLevelData_Records : BasePerkLevelData_Records
	{
		private wCHandle<gamedataNewPerk_Record> _perkRecord;
		private CArray<wCHandle<gamedataNewPerkLevelData_Record>> _arr;

		[Ordinal(0)] 
		[RED("perkRecord")] 
		public wCHandle<gamedataNewPerk_Record> PerkRecord
		{
			get => GetProperty(ref _perkRecord);
			set => SetProperty(ref _perkRecord, value);
		}

		[Ordinal(1)] 
		[RED("arr")] 
		public CArray<wCHandle<gamedataNewPerkLevelData_Record>> Arr
		{
			get => GetProperty(ref _arr);
			set => SetProperty(ref _arr, value);
		}

		public NewPerkLevelData_Records(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
