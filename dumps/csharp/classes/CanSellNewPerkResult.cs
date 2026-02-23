using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CanSellNewPerkResult : CVariable
	{
		private CBool _success;
		private CString _title;
		private CString _message;
		private CEnum<gamedataNewPerkType> _perkType;

		[Ordinal(0)] 
		[RED("success")] 
		public CBool Success
		{
			get => GetProperty(ref _success);
			set => SetProperty(ref _success, value);
		}

		[Ordinal(1)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(2)] 
		[RED("message")] 
		public CString Message
		{
			get => GetProperty(ref _message);
			set => SetProperty(ref _message, value);
		}

		[Ordinal(3)] 
		[RED("perkType")] 
		public CEnum<gamedataNewPerkType> PerkType
		{
			get => GetProperty(ref _perkType);
			set => SetProperty(ref _perkType, value);
		}

		public CanSellNewPerkResult(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
