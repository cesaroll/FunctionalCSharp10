/*
 * @author: Cesar Lopez
 * @copyright 2023 - All rights reserved
 */
namespace Models.Types;

public record ExternalSkuPhoto(byte[] Content, string MimeType, Vendor Vendor);
