using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SkillHoverOver : redEvent
	{
		private wCHandle<inkWidget> _widget;
		private CString _title;
		private CString _description;

		[Ordinal(0)] 
		[RED("widget")] 
		public wCHandle<inkWidget> Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}

		[Ordinal(1)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(2)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		public SkillHoverOver(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
