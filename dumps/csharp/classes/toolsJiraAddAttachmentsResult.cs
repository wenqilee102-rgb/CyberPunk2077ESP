using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsJiraAddAttachmentsResult : ISerializable
	{
		private CArray<toolsJiraAttachment> _array;

		[Ordinal(0)] 
		[RED("array")] 
		public CArray<toolsJiraAttachment> Array
		{
			get => GetProperty(ref _array);
			set => SetProperty(ref _array, value);
		}

		public toolsJiraAddAttachmentsResult(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
