using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class oauthAuthenticationToken : CVariable
	{
		private CString _token;
		private CString _secret;
		private CString _sessionHandle;
		private CUInt64 _tokenExpiresIn;
		private CUInt64 _authorizationExpiresIn;

		[Ordinal(0)] 
		[RED("token")] 
		public CString Token
		{
			get => GetProperty(ref _token);
			set => SetProperty(ref _token, value);
		}

		[Ordinal(1)] 
		[RED("secret")] 
		public CString Secret
		{
			get => GetProperty(ref _secret);
			set => SetProperty(ref _secret, value);
		}

		[Ordinal(2)] 
		[RED("sessionHandle")] 
		public CString SessionHandle
		{
			get => GetProperty(ref _sessionHandle);
			set => SetProperty(ref _sessionHandle, value);
		}

		[Ordinal(3)] 
		[RED("tokenExpiresIn")] 
		public CUInt64 TokenExpiresIn
		{
			get => GetProperty(ref _tokenExpiresIn);
			set => SetProperty(ref _tokenExpiresIn, value);
		}

		[Ordinal(4)] 
		[RED("authorizationExpiresIn")] 
		public CUInt64 AuthorizationExpiresIn
		{
			get => GetProperty(ref _authorizationExpiresIn);
			set => SetProperty(ref _authorizationExpiresIn, value);
		}

		public oauthAuthenticationToken(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
