using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;
/// <summary>
/// Summary description for sha256
/// </summary>
public class SHA512 {
	public SHA512() {
		//
		// TODO: Add constructor logic here
		//
	}
	public static string EncodePassword(string originalPassword) {
		var sha = System.Security.Cryptography.SHA512Managed.Create();

		//originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
		//encodedBytes = sha512.ComputeHash(originalBytes);
		//Convert encoded bytes back to a 'readable' string
		//return BitConverter.ToString(encodedBytes);
		return null;
	}
}