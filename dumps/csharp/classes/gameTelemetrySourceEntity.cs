using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTelemetrySourceEntity : CVariable
	{
		private CString _className;
		private TweakDBID _sourceEntityRecord;

		[Ordinal(0)] 
		[RED("className")] 
		public CString ClassName
		{
			get => GetProperty(ref _className);
			set => SetProperty(ref _className, value);
		}

		[Ordinal(1)] 
		[RED("sourceEntityRecord")] 
		public TweakDBID SourceEntityRecord
		{
			get => GetProperty(ref _sourceEntityRecord);
			set => SetProperty(ref _sourceEntityRecord, value);
		}

		public gameTelemetrySourceEntity(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
