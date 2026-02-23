using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FilterRadioItemHoverOut : redEvent
	{
		private wCHandle<inkWidget> _target;
		private CInt32 _identifier;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<inkWidget> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("identifier")] 
		public CInt32 Identifier
		{
			get => GetProperty(ref _identifier);
			set => SetProperty(ref _identifier, value);
		}

		public FilterRadioItemHoverOut(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
