using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipDataStatRequirement : IScriptable
	{
		private CString _statName;
		private CString _statColor;
		private CString _statLocKey;
		private CInt32 _statValue;

		[Ordinal(0)] 
		[RED("statName")] 
		public CString StatName
		{
			get => GetProperty(ref _statName);
			set => SetProperty(ref _statName, value);
		}

		[Ordinal(1)] 
		[RED("statColor")] 
		public CString StatColor
		{
			get => GetProperty(ref _statColor);
			set => SetProperty(ref _statColor, value);
		}

		[Ordinal(2)] 
		[RED("statLocKey")] 
		public CString StatLocKey
		{
			get => GetProperty(ref _statLocKey);
			set => SetProperty(ref _statLocKey, value);
		}

		[Ordinal(3)] 
		[RED("statValue")] 
		public CInt32 StatValue
		{
			get => GetProperty(ref _statValue);
			set => SetProperty(ref _statValue, value);
		}

		public MinimalItemTooltipDataStatRequirement(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
