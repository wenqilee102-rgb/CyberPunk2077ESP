using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ResetNPCSensesMainPreset : AIbehaviortaskScript
	{
		private CString _newSensesPresetName;

		[Ordinal(0)] 
		[RED("newSensesPresetName")] 
		public CString NewSensesPresetName
		{
			get => GetProperty(ref _newSensesPresetName);
			set => SetProperty(ref _newSensesPresetName, value);
		}

		public ResetNPCSensesMainPreset(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
