using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleWeakspotHighlightEvent : redEvent
	{
		private CName _sourceName;
		private CEnum<EToggleOperationType> _operation;

		[Ordinal(0)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get => GetProperty(ref _sourceName);
			set => SetProperty(ref _sourceName, value);
		}

		[Ordinal(1)] 
		[RED("operation")] 
		public CEnum<EToggleOperationType> Operation
		{
			get => GetProperty(ref _operation);
			set => SetProperty(ref _operation, value);
		}

		public ToggleWeakspotHighlightEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
