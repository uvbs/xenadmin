/*
 * Copyright (c) Cloud Software Group, Inc.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions
 * are met:
 *
 *   1) Redistributions of source code must retain the above copyright
 *      notice, this list of conditions and the following disclaimer.
 *
 *   2) Redistributions in binary form must reproduce the above
 *      copyright notice, this list of conditions and the following
 *      disclaimer in the documentation and/or other materials
 *      provided with the distribution.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
 * "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
 * LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS
 * FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE
 * COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
 * INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
 * HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
 * STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED
 * OF THE POSSIBILITY OF SUCH DAMAGE.
 */


using System;
using System.Collections;
using System.Collections.Generic;

     namespace XenAPI
{
    internal class Maps
    {
        internal static Dictionary<string, string> convert_from_proxy_string_string(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key;
                        string v = table[key] == null ? null : (string)table[key];
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_string_string(Dictionary<string, string> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key ?? "";
                        string v = table[key] ?? "";
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<string, long> convert_from_proxy_string_long(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<string, long> result = new Dictionary<string, long>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key;
                        long v = table[key] == null ? 0 : long.Parse((string)table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_string_long(Dictionary<string, long> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key ?? "";
                        string v = table[key].ToString();
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<string, cluster_host_operation> convert_from_proxy_string_cluster_host_operation(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<string, cluster_host_operation> result = new Dictionary<string, cluster_host_operation>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key;
                        cluster_host_operation v = table[key] == null ? (cluster_host_operation) 0 : (cluster_host_operation)Helper.EnumParseDefault(typeof(cluster_host_operation), (string)table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_string_cluster_host_operation(Dictionary<string, cluster_host_operation> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key ?? "";
                        string v = cluster_host_operation_helper.ToString(table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<string, cluster_operation> convert_from_proxy_string_cluster_operation(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<string, cluster_operation> result = new Dictionary<string, cluster_operation>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key;
                        cluster_operation v = table[key] == null ? (cluster_operation) 0 : (cluster_operation)Helper.EnumParseDefault(typeof(cluster_operation), (string)table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_string_cluster_operation(Dictionary<string, cluster_operation> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key ?? "";
                        string v = cluster_operation_helper.ToString(table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<string, host_allowed_operations> convert_from_proxy_string_host_allowed_operations(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<string, host_allowed_operations> result = new Dictionary<string, host_allowed_operations>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key;
                        host_allowed_operations v = table[key] == null ? (host_allowed_operations) 0 : (host_allowed_operations)Helper.EnumParseDefault(typeof(host_allowed_operations), (string)table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_string_host_allowed_operations(Dictionary<string, host_allowed_operations> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key ?? "";
                        string v = host_allowed_operations_helper.ToString(table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<string, network_operations> convert_from_proxy_string_network_operations(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<string, network_operations> result = new Dictionary<string, network_operations>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key;
                        network_operations v = table[key] == null ? (network_operations) 0 : (network_operations)Helper.EnumParseDefault(typeof(network_operations), (string)table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_string_network_operations(Dictionary<string, network_operations> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key ?? "";
                        string v = network_operations_helper.ToString(table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<string, pool_allowed_operations> convert_from_proxy_string_pool_allowed_operations(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<string, pool_allowed_operations> result = new Dictionary<string, pool_allowed_operations>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key;
                        pool_allowed_operations v = table[key] == null ? (pool_allowed_operations) 0 : (pool_allowed_operations)Helper.EnumParseDefault(typeof(pool_allowed_operations), (string)table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_string_pool_allowed_operations(Dictionary<string, pool_allowed_operations> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key ?? "";
                        string v = pool_allowed_operations_helper.ToString(table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<string, storage_operations> convert_from_proxy_string_storage_operations(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<string, storage_operations> result = new Dictionary<string, storage_operations>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key;
                        storage_operations v = table[key] == null ? (storage_operations) 0 : (storage_operations)Helper.EnumParseDefault(typeof(storage_operations), (string)table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_string_storage_operations(Dictionary<string, storage_operations> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key ?? "";
                        string v = storage_operations_helper.ToString(table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<string, task_allowed_operations> convert_from_proxy_string_task_allowed_operations(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<string, task_allowed_operations> result = new Dictionary<string, task_allowed_operations>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key;
                        task_allowed_operations v = table[key] == null ? (task_allowed_operations) 0 : (task_allowed_operations)Helper.EnumParseDefault(typeof(task_allowed_operations), (string)table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_string_task_allowed_operations(Dictionary<string, task_allowed_operations> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key ?? "";
                        string v = task_allowed_operations_helper.ToString(table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<string, vbd_operations> convert_from_proxy_string_vbd_operations(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<string, vbd_operations> result = new Dictionary<string, vbd_operations>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key;
                        vbd_operations v = table[key] == null ? (vbd_operations) 0 : (vbd_operations)Helper.EnumParseDefault(typeof(vbd_operations), (string)table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_string_vbd_operations(Dictionary<string, vbd_operations> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key ?? "";
                        string v = vbd_operations_helper.ToString(table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<string, vdi_operations> convert_from_proxy_string_vdi_operations(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<string, vdi_operations> result = new Dictionary<string, vdi_operations>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key;
                        vdi_operations v = table[key] == null ? (vdi_operations) 0 : (vdi_operations)Helper.EnumParseDefault(typeof(vdi_operations), (string)table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_string_vdi_operations(Dictionary<string, vdi_operations> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key ?? "";
                        string v = vdi_operations_helper.ToString(table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<string, vif_operations> convert_from_proxy_string_vif_operations(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<string, vif_operations> result = new Dictionary<string, vif_operations>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key;
                        vif_operations v = table[key] == null ? (vif_operations) 0 : (vif_operations)Helper.EnumParseDefault(typeof(vif_operations), (string)table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_string_vif_operations(Dictionary<string, vif_operations> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key ?? "";
                        string v = vif_operations_helper.ToString(table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<string, vm_appliance_operation> convert_from_proxy_string_vm_appliance_operation(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<string, vm_appliance_operation> result = new Dictionary<string, vm_appliance_operation>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key;
                        vm_appliance_operation v = table[key] == null ? (vm_appliance_operation) 0 : (vm_appliance_operation)Helper.EnumParseDefault(typeof(vm_appliance_operation), (string)table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_string_vm_appliance_operation(Dictionary<string, vm_appliance_operation> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key ?? "";
                        string v = vm_appliance_operation_helper.ToString(table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<string, vm_operations> convert_from_proxy_string_vm_operations(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<string, vm_operations> result = new Dictionary<string, vm_operations>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key;
                        vm_operations v = table[key] == null ? (vm_operations) 0 : (vm_operations)Helper.EnumParseDefault(typeof(vm_operations), (string)table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_string_vm_operations(Dictionary<string, vm_operations> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key ?? "";
                        string v = vm_operations_helper.ToString(table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<string, vtpm_operations> convert_from_proxy_string_vtpm_operations(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<string, vtpm_operations> result = new Dictionary<string, vtpm_operations>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key;
                        vtpm_operations v = table[key] == null ? (vtpm_operations) 0 : (vtpm_operations)Helper.EnumParseDefault(typeof(vtpm_operations), (string)table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_string_vtpm_operations(Dictionary<string, vtpm_operations> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key ?? "";
                        string v = vtpm_operations_helper.ToString(table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<string, vusb_operations> convert_from_proxy_string_vusb_operations(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<string, vusb_operations> result = new Dictionary<string, vusb_operations>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key;
                        vusb_operations v = table[key] == null ? (vusb_operations) 0 : (vusb_operations)Helper.EnumParseDefault(typeof(vusb_operations), (string)table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_string_vusb_operations(Dictionary<string, vusb_operations> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key ?? "";
                        string v = vusb_operations_helper.ToString(table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<string, XenRef<Blob>> convert_from_proxy_string_XenRefBlob(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<string, XenRef<Blob>> result = new Dictionary<string, XenRef<Blob>>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key;
                        XenRef<Blob> v = table[key] == null ? null : XenRef<Blob>.Create(table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_string_XenRefBlob(Dictionary<string, XenRef<Blob>> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        string k = key ?? "";
                        string v = table[key] ?? "";
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<long, long> convert_from_proxy_long_long(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<long, long> result = new Dictionary<long, long>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        long k = long.Parse(key);
                        long v = table[key] == null ? 0 : long.Parse((string)table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_long_long(Dictionary<long, long> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (long key in table.Keys)
                {
                    try
                    {
                        string k = key.ToString();
                        string v = table[key].ToString();
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<long, double> convert_from_proxy_long_double(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<long, double> result = new Dictionary<long, double>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        long k = long.Parse(key);
                        double v = Convert.ToDouble(table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_long_double(Dictionary<long, double> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (long key in table.Keys)
                {
                    try
                    {
                        string k = key.ToString();
                        double v = table[key];
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<long, string[]> convert_from_proxy_long_string_array(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<long, string[]> result = new Dictionary<long, string[]>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        long k = long.Parse(key);
                        string[] v = table[key] == null ? new string[] {} : Array.ConvertAll<object, string>((object[])table[key], Convert.ToString);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_long_string_array(Dictionary<long, string[]> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (long key in table.Keys)
                {
                    try
                    {
                        string k = key.ToString();
                        string[] v = table[key];
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<vm_operations, string> convert_from_proxy_vm_operations_string(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<vm_operations, string> result = new Dictionary<vm_operations, string>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        vm_operations k = (vm_operations)Helper.EnumParseDefault(typeof(vm_operations), (string)key);
                        string v = table[key] == null ? null : (string)table[key];
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_vm_operations_string(Dictionary<vm_operations, string> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (vm_operations key in table.Keys)
                {
                    try
                    {
                        string k = vm_operations_helper.ToString(key);
                        string v = table[key] ?? "";
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<XenRef<VGPU_type>, long> convert_from_proxy_XenRefVGPU_type_long(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<XenRef<VGPU_type>, long> result = new Dictionary<XenRef<VGPU_type>, long>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        XenRef<VGPU_type> k = XenRef<VGPU_type>.Create(key);
                        long v = table[key] == null ? 0 : long.Parse((string)table[key]);
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_XenRefVGPU_type_long(Dictionary<XenRef<VGPU_type>, long> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (XenRef<VGPU_type> key in table.Keys)
                {
                    try
                    {
                        string k = key ?? "";
                        string v = table[key].ToString();
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


        internal static Dictionary<XenRef<VIF>, string> convert_from_proxy_XenRefVIF_string(Object o)
        {
            Hashtable table = (Hashtable)o;
            Dictionary<XenRef<VIF>, string> result = new Dictionary<XenRef<VIF>, string>();
            if (table != null)
            {
                foreach (string key in table.Keys)
                {
                    try
                    {
                        XenRef<VIF> k = XenRef<VIF>.Create(key);
                        string v = table[key] == null ? null : (string)table[key];
                        result[k] = v;
                    }
                    catch
                    {
                       // continue
                    }
                }
            }
            return result;
        }

        internal static Hashtable convert_to_proxy_XenRefVIF_string(Dictionary<XenRef<VIF>, string> table)
        {
            var result = new Hashtable();
            if (table != null)
            {
                foreach (XenRef<VIF> key in table.Keys)
                {
                    try
                    {
                        string k = key ?? "";
                        string v = table[key] ?? "";
                        result[k] = v;
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
            return result;
        }


    }
}
