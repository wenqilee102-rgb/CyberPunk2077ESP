using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRequestPopContextEvent : redEvent
	{
		private CEnum<UIGameContext> _context;
		private CBool _invalidate;

		[Ordinal(0)] 
		[RED("context")] 
		public CEnum<UIGameContext> Context
		{
			get => GetProperty(ref _context);
			set => SetProperty(ref _context, value);
		}

		[Ordinal(1)] 
		[RED("invalidate")] 
		public CBool Invalidate
		{
			get => GetProperty(ref _invalidate);
			set => SetProperty(ref _invalidate, value);
		}

		public gameuiRequestPopContextEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
