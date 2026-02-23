using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipmentChangeTaskData : gameScriptTaskData
	{
		private SPaperdollEquipData _eqData;

		[Ordinal(0)] 
		[RED("eqData")] 
		public SPaperdollEquipData EqData
		{
			get => GetProperty(ref _eqData);
			set => SetProperty(ref _eqData, value);
		}

		public EquipmentChangeTaskData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
