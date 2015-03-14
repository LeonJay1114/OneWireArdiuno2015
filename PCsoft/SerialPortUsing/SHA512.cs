using System;
using System.Security.Cryptography;
using System.Text;

namespace SerialPortUsing {
	public static class SHA512 {
		public static string EncodePassword(string password, int saltLength, ref string salt) {
			byte[] passBytes = Encoding.Unicode.GetBytes(password);
			byte[] saltBytes = MakeSalt(saltLength);

			int totalL = passBytes.Length + saltBytes.Length;
			byte[] passAndSalt = new byte[totalL];

			passBytes.CopyTo(passAndSalt, 0);
			saltBytes.CopyTo(passAndSalt, passBytes.Length);

			SHA512Managed sha = new SHA512Managed();
			byte[] hashed = sha.ComputeHash(passAndSalt, 0, totalL);
			//byte[] hashed = sha.TransformFinalBlock(passAndSalt, 0, totalL); Этот считает блоками по 1 байту. Не камильфо.

			salt = Convert.ToBase64String(saltBytes);
			return Convert.ToBase64String(hashed);
		}

		public static bool CheckPassword(string password, string salt, string hash) {
			byte[] passBytes = Encoding.Unicode.GetBytes(password);
			byte[] saltBytes = Convert.FromBase64String(salt);

			int totalL = passBytes.Length + saltBytes.Length;
			byte[] passAndSalt = new byte[totalL];

			passBytes.CopyTo(passAndSalt, 0);
			saltBytes.CopyTo(passAndSalt, passBytes.Length);

			SHA512Managed sha = new SHA512Managed();
			byte[] hashed = sha.ComputeHash(passAndSalt, 0, totalL);

			return Convert.ToBase64String(hashed) == hash;
		}

		private static byte[] MakeSalt(int saltLength) {
			byte[] rez = new byte[saltLength];
			Random r = new Random();
			for (int i = 0; i < saltLength; i++) {
				rez[i] = (byte)r.Next(255);
			}
			return rez;
		}

	}
}