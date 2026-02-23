using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSD_Trigger : gameObject
	{
		private NodeRef _ref;
		private CName _className;

		[Ordinal(36)] 
		[RED("ref")] 
		public NodeRef Ref
		{
			get => GetProperty(ref _ref);
			set => SetProperty(ref _ref, value);
		}

		[Ordinal(37)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetProperty(ref _className);
			set => SetProperty(ref _className, value);
		}

		public PSD_Trigger(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
