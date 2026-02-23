using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FactInvokerControllerPS : MasterControllerPS
	{
		private CArray<CHandle<FactInvokerDataEntry>> _factDataEntries;
		private CArray<CName> _passwords;
		private CBool _arePasswordsInitialized;

		[Ordinal(108)] 
		[RED("factDataEntries")] 
		public CArray<CHandle<FactInvokerDataEntry>> FactDataEntries
		{
			get => GetProperty(ref _factDataEntries);
			set => SetProperty(ref _factDataEntries, value);
		}

		[Ordinal(109)] 
		[RED("passwords")] 
		public CArray<CName> Passwords
		{
			get => GetProperty(ref _passwords);
			set => SetProperty(ref _passwords, value);
		}

		[Ordinal(110)] 
		[RED("arePasswordsInitialized")] 
		public CBool ArePasswordsInitialized
		{
			get => GetProperty(ref _arePasswordsInitialized);
			set => SetProperty(ref _arePasswordsInitialized, value);
		}

		public FactInvokerControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
