//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//
// @dart=2.12

// ignore_for_file: unused_element, unused_import
// ignore_for_file: always_put_required_named_parameters_first
// ignore_for_file: constant_identifier_names
// ignore_for_file: lines_longer_than_80_chars

part of openapi.api;

class SubmitSelfServiceRegistrationFlowBody {
  /// Returns a new [SubmitSelfServiceRegistrationFlowBody] instance.
  SubmitSelfServiceRegistrationFlowBody({
    this.csrfToken,
    required this.method,
    required this.password,
    required this.traits,
    required this.provider,
    this.webauthnRegister,
    this.webauthnRegisterDisplayname,
  });

  /// CSRFToken is the anti-CSRF token
  ///
  /// Please note: This property should have been non-nullable! Since the specification file
  /// does not include a default value (using the "default:" property), however, the generated
  /// source code must fall back to having a nullable type.
  /// Consider adding a "default:" property in the specification file to hide this note.
  ///
  String? csrfToken;

  /// Method  Should be set to \"webauthn\" when trying to add, update, or remove a webAuthn pairing.
  String method;

  /// Password to sign the user up with
  String password;

  /// The identity's traits
  Object traits;

  /// The provider to register with
  String provider;

  /// Register a WebAuthn Security Key  It is expected that the JSON returned by the WebAuthn registration process is included here.
  ///
  /// Please note: This property should have been non-nullable! Since the specification file
  /// does not include a default value (using the "default:" property), however, the generated
  /// source code must fall back to having a nullable type.
  /// Consider adding a "default:" property in the specification file to hide this note.
  ///
  String? webauthnRegister;

  /// Name of the WebAuthn Security Key to be Added  A human-readable name for the security key which will be added.
  ///
  /// Please note: This property should have been non-nullable! Since the specification file
  /// does not include a default value (using the "default:" property), however, the generated
  /// source code must fall back to having a nullable type.
  /// Consider adding a "default:" property in the specification file to hide this note.
  ///
  String? webauthnRegisterDisplayname;

  @override
  bool operator ==(Object other) => identical(this, other) || other is SubmitSelfServiceRegistrationFlowBody &&
     other.csrfToken == csrfToken &&
     other.method == method &&
     other.password == password &&
     other.traits == traits &&
     other.provider == provider &&
     other.webauthnRegister == webauthnRegister &&
     other.webauthnRegisterDisplayname == webauthnRegisterDisplayname;

  @override
  int get hashCode =>
    // ignore: unnecessary_parenthesis
    (csrfToken == null ? 0 : csrfToken!.hashCode) +
    (method.hashCode) +
    (password.hashCode) +
    (traits.hashCode) +
    (provider.hashCode) +
    (webauthnRegister == null ? 0 : webauthnRegister!.hashCode) +
    (webauthnRegisterDisplayname == null ? 0 : webauthnRegisterDisplayname!.hashCode);

  @override
  String toString() => 'SubmitSelfServiceRegistrationFlowBody[csrfToken=$csrfToken, method=$method, password=$password, traits=$traits, provider=$provider, webauthnRegister=$webauthnRegister, webauthnRegisterDisplayname=$webauthnRegisterDisplayname]';

  Map<String, dynamic> toJson() {
    final _json = <String, dynamic>{};
    if (csrfToken != null) {
      _json[r'csrf_token'] = csrfToken;
    } else {
      _json[r'csrf_token'] = null;
    }
      _json[r'method'] = method;
      _json[r'password'] = password;
      _json[r'traits'] = traits;
      _json[r'provider'] = provider;
    if (webauthnRegister != null) {
      _json[r'webauthn_register'] = webauthnRegister;
    } else {
      _json[r'webauthn_register'] = null;
    }
    if (webauthnRegisterDisplayname != null) {
      _json[r'webauthn_register_displayname'] = webauthnRegisterDisplayname;
    } else {
      _json[r'webauthn_register_displayname'] = null;
    }
    return _json;
  }

  /// Returns a new [SubmitSelfServiceRegistrationFlowBody] instance and imports its values from
  /// [value] if it's a [Map], null otherwise.
  // ignore: prefer_constructors_over_static_methods
  static SubmitSelfServiceRegistrationFlowBody? fromJson(dynamic value) {
    if (value is Map) {
      final json = value.cast<String, dynamic>();

      // Ensure that the map contains the required keys.
      // Note 1: the values aren't checked for validity beyond being non-null.
      // Note 2: this code is stripped in release mode!
      assert(() {
        requiredKeys.forEach((key) {
          assert(json.containsKey(key), 'Required key "SubmitSelfServiceRegistrationFlowBody[$key]" is missing from JSON.');
          assert(json[key] != null, 'Required key "SubmitSelfServiceRegistrationFlowBody[$key]" has a null value in JSON.');
        });
        return true;
      }());

      return SubmitSelfServiceRegistrationFlowBody(
        csrfToken: mapValueOfType<String>(json, r'csrf_token'),
        method: mapValueOfType<String>(json, r'method')!,
        password: mapValueOfType<String>(json, r'password')!,
        traits: mapValueOfType<Object>(json, r'traits')!,
        provider: mapValueOfType<String>(json, r'provider')!,
        webauthnRegister: mapValueOfType<String>(json, r'webauthn_register'),
        webauthnRegisterDisplayname: mapValueOfType<String>(json, r'webauthn_register_displayname'),
      );
    }
    return null;
  }

  static List<SubmitSelfServiceRegistrationFlowBody>? listFromJson(dynamic json, {bool growable = false,}) {
    final result = <SubmitSelfServiceRegistrationFlowBody>[];
    if (json is List && json.isNotEmpty) {
      for (final row in json) {
        final value = SubmitSelfServiceRegistrationFlowBody.fromJson(row);
        if (value != null) {
          result.add(value);
        }
      }
    }
    return result.toList(growable: growable);
  }

  static Map<String, SubmitSelfServiceRegistrationFlowBody> mapFromJson(dynamic json) {
    final map = <String, SubmitSelfServiceRegistrationFlowBody>{};
    if (json is Map && json.isNotEmpty) {
      json = json.cast<String, dynamic>(); // ignore: parameter_assignments
      for (final entry in json.entries) {
        final value = SubmitSelfServiceRegistrationFlowBody.fromJson(entry.value);
        if (value != null) {
          map[entry.key] = value;
        }
      }
    }
    return map;
  }

  // maps a json object with a list of SubmitSelfServiceRegistrationFlowBody-objects as value to a dart map
  static Map<String, List<SubmitSelfServiceRegistrationFlowBody>> mapListFromJson(dynamic json, {bool growable = false,}) {
    final map = <String, List<SubmitSelfServiceRegistrationFlowBody>>{};
    if (json is Map && json.isNotEmpty) {
      json = json.cast<String, dynamic>(); // ignore: parameter_assignments
      for (final entry in json.entries) {
        final value = SubmitSelfServiceRegistrationFlowBody.listFromJson(entry.value, growable: growable,);
        if (value != null) {
          map[entry.key] = value;
        }
      }
    }
    return map;
  }

  /// The list of required keys that must be present in a JSON.
  static const requiredKeys = <String>{
    'method',
    'password',
    'traits',
    'provider',
  };
}

