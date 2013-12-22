/*
 *  This Project is a Fork of ServiceStack 3.x version's Caching framework developed 
 *  by the ServiceStack Developers https://github.com/ServiceStack .
 *  
 * ServiceStack 3.x is licensed under BSD.
 * 
 * This fork is created by Guru Kathiresan and licensed under BSD.
 * 
 * For more information visit - https://github.com/gkathire/cachelite
 */

namespace CacheLite
{
    public interface IDeflateProvider
    {
        byte[] Deflate(string text);

        string Inflate(byte[] gzBuffer);
    }
}
