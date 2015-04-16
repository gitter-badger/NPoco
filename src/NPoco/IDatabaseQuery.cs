using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using NPoco.Expressions;
using NPoco.Linq;
#if NET45
using System.Threading.Tasks;
#endif

namespace NPoco
{
    public interface IDatabaseQuery
    {
        void OpenSharedConnection();
        void CloseSharedConnection();
        void BuildPageQueries<T>(long skip, long take, string sql, ref object[] args, out string sqlCount, out string sqlPage);
        int Execute(string sql, params object[] args);
        int Execute(Sql sql);
        T ExecuteScalar<T>(string sql, params object[] args);
        T ExecuteScalar<T>(Sql sql);
        List<T> Fetch<T>();
        List<T> Fetch<T>(string sql, params object[] args);
        List<T> Fetch<T>(Sql sql);
        List<T> Fetch<T>(long page, long itemsPerPage, string sql, params object[] args);
        List<T> Fetch<T>(long page, long itemsPerPage, Sql sql);
        Page<T> Page<T>(long page, long itemsPerPage, string sql, params object[] args);
        Page<T> Page<T>(long page, long itemsPerPage, Sql sql);
        List<T> SkipTake<T>(long skip, long take, string sql, params object[] args);
        List<T> SkipTake<T>(long skip, long take, Sql sql);
        List<TRet> Fetch<T1, T2, TRet>(Func<T1, T2, TRet> cb, string sql, params object[] args);
        List<TRet> Fetch<T1, T2, T3, TRet>(Func<T1, T2, T3, TRet> cb, string sql, params object[] args);
        List<TRet> Fetch<T1, T2, T3, T4, TRet>(Func<T1, T2, T3, T4, TRet> cb, string sql, params object[] args);
        IEnumerable<TRet> Query<T1, T2, TRet>(Func<T1, T2, TRet> cb, string sql, params object[] args);
        IEnumerable<TRet> Query<T1, T2, T3, TRet>(Func<T1, T2, T3, TRet> cb, string sql, params object[] args);
        IEnumerable<TRet> Query<T1, T2, T3, T4, TRet>(Func<T1, T2, T3, T4, TRet> cb, string sql, params object[] args);
        Page<TRet> Page<T1, T2, TRet>(Func<T1, T2, TRet> cb, long page, long itemsPerPage, string sql, params object[] args);
        Page<TRet> Page<T1, T2, T3, TRet>(Func<T1, T2, T3, TRet> cb, long page, long itemsPerPage, string sql, params object[] args);
        Page<TRet> Page<T1, T2, T3, T4, TRet>(Func<T1, T2, T3, T4, TRet> cb, long page, long itemsPerPage, string sql, params object[] args);
        List<TRet> Fetch<T1, T2, TRet>(Func<T1, T2, TRet> cb, Sql sql);
        List<TRet> Fetch<T1, T2, T3, TRet>(Func<T1, T2, T3, TRet> cb, Sql sql);
        List<TRet> Fetch<T1, T2, T3, T4, TRet>(Func<T1, T2, T3, T4, TRet> cb, Sql sql);
        IEnumerable<TRet> Query<T1, T2, TRet>(Func<T1, T2, TRet> cb, Sql sql);
        IEnumerable<TRet> Query<T1, T2, T3, TRet>(Func<T1, T2, T3, TRet> cb, Sql sql);
        IEnumerable<TRet> Query<T1, T2, T3, T4, TRet>(Func<T1, T2, T3, T4, TRet> cb, Sql sql);
        Page<TRet> Page<T1, T2, TRet>(Func<T1, T2, TRet> cb, long page, long itemsPerPage, Sql sql);
        Page<TRet> Page<T1, T2, T3, TRet>(Func<T1, T2, T3, TRet> cb, long page, long itemsPerPage, Sql sql);
        Page<TRet> Page<T1, T2, T3, T4, TRet>(Func<T1, T2, T3, T4, TRet> cb, long page, long itemsPerPage, Sql sql);
        List<T1> Fetch<T1, T2>(string sql, params object[] args);
        List<T1> Fetch<T1, T2, T3>(string sql, params object[] args);
        List<T1> Fetch<T1, T2, T3, T4>(string sql, params object[] args);
        IEnumerable<T1> Query<T1, T2>(string sql, params object[] args);
        IEnumerable<T1> Query<T1, T2, T3>(string sql, params object[] args);
        IEnumerable<T1> Query<T1, T2, T3, T4>(string sql, params object[] args);
        Page<T1> Page<T1, T2>(long page, long itemsPerPage, string sql, params object[] args);
        Page<T1> Page<T1, T2, T3>(long page, long itemsPerPage, string sql, params object[] args);
        Page<T1> Page<T1, T2, T3, T4>(long page, long itemsPerPage, string sql, params object[] args);
        IEnumerable<TRet> Query<TRet>(Type[] types, Delegate cb, Sql sql);
        Page<TRet> Page<TRet>(Type[] types, Delegate cb, long page, long itemsPerPage, string sql, params object[] args);
        List<T1> Fetch<T1, T2>(Sql sql);
        List<T1> Fetch<T1, T2, T3>(Sql sql);
        List<T1> Fetch<T1, T2, T3, T4>(Sql sql);
        IEnumerable<T1> Query<T1, T2>(Sql sql);
        IEnumerable<T1> Query<T1, T2, T3>(Sql sql);
        IEnumerable<T1> Query<T1, T2, T3, T4>(Sql sql);
        Page<T1> Page<T1, T2>(long page, long itemsPerpage, Sql sql);
        Page<T1> Page<T1, T2, T3>(long page, long itemsPerpage, Sql sql);
        Page<T1> Page<T1, T2, T3, T4>(long page, long itemsPerpage, Sql sql);
        IEnumerable<T> Query<T>(string sql, params object[] args);
        IEnumerable<T> Query<T>(Sql sql);
        IQueryProviderWithIncludes<T> Query<T>();
        T SingleById<T>(object primaryKey);
        T SingleOrDefaultById<T>(object primaryKey);
        T Single<T>(string sql, params object[] args);
        T SingleInto<T>(T instance, string sql, params object[] args);
        T SingleOrDefault<T>(string sql, params object[] args);
        T SingleOrDefaultInto<T>(T instance, string sql, params object[] args);
        T First<T>(string sql, params object[] args);
        T FirstInto<T>(T instance, string sql, params object[] args);
        T FirstOrDefault<T>(string sql, params object[] args);
        T FirstOrDefaultInto<T>(T instance, string sql, params object[] args);
        T Single<T>(Sql sql);
        T SingleInto<T>(T instance, Sql sql);
        T SingleOrDefault<T>(Sql sql);
        T SingleOrDefaultInto<T>(T instance, Sql sql);
        T First<T>(Sql sql);
        T FirstInto<T>(T instance, Sql sql);
        T FirstOrDefault<T>(Sql sql);
        T FirstOrDefaultInto<T>(T instance, Sql sql);
        Dictionary<TKey, TValue> Dictionary<TKey, TValue>(Sql Sql);
        Dictionary<TKey, TValue> Dictionary<TKey, TValue>(string sql, params object[] args);
        bool Exists<T>(object primaryKey);
        int OneTimeCommandTimeout { get; set; }

        TRet FetchMultiple<T1, T2, TRet>(Func<List<T1>, List<T2>, TRet> cb, string sql, params object[] args);
        TRet FetchMultiple<T1, T2, T3, TRet>(Func<List<T1>, List<T2>, List<T3>, TRet> cb, string sql, params object[] args);
        TRet FetchMultiple<T1, T2, T3, T4, TRet>(Func<List<T1>, List<T2>, List<T3>, List<T4>, TRet> cb, string sql, params object[] args);
        TRet FetchMultiple<T1, T2, TRet>(Func<List<T1>, List<T2>, TRet> cb, Sql sql);
        TRet FetchMultiple<T1, T2, T3, TRet>(Func<List<T1>, List<T2>, List<T3>, TRet> cb, Sql sql);
        TRet FetchMultiple<T1, T2, T3, T4, TRet>(Func<List<T1>, List<T2>, List<T3>, List<T4>, TRet> cb, Sql sql);

        Tuple<List<T1>, List<T2>> FetchMultiple<T1, T2>(string sql, params object[] args);
        Tuple<List<T1>, List<T2>, List<T3>> FetchMultiple<T1, T2, T3>(string sql, params object[] args);
        Tuple<List<T1>, List<T2>, List<T3>, List<T4>> FetchMultiple<T1, T2, T3, T4>(string sql, params object[] args);
        Tuple<List<T1>, List<T2>> FetchMultiple<T1, T2>(Sql sql);
        Tuple<List<T1>, List<T2>, List<T3>> FetchMultiple<T1, T2, T3>(Sql sql);
        Tuple<List<T1>, List<T2>, List<T3>, List<T4>> FetchMultiple<T1, T2, T3, T4>(Sql sql);

#if NET45
        Task<IEnumerable<T>> QueryAsync<T>(string sql, object[] args);
        Task<IEnumerable<T>> QueryAsync<T>(Sql sql);
        Task<IEnumerable<T>> QueryAsync<T>(Type[] types, Delegate cb, Sql sql);

        Task<IEnumerable<T>> FetchAsync<T>(string sql, params object[] args);
        Task<IEnumerable<T>> FetchAsync<T>(Sql sql);

        Task<Page<T>> PageAsync<T>(long page, long itemsPerPage, string sql, params object[] args);
        Task<Page<T>> PageAsync<T>(long page, long itemsPerPage, Sql sql); 
        Task<Page<T>> PageAsync<T>(Type[] types, Delegate cb, long page, long itemsPerPage, string sql, params object[] args);
        
        Task<T> ExecuteScalarAsync<T>(string sql, object[] args);
        Task<T> ExecuteScalarAsync<T>(Sql sql);
        Task<int> ExecuteAsync(string sql, params object[] args);
        Task<int> ExecuteAsync(Sql sql);
#endif
    }
}