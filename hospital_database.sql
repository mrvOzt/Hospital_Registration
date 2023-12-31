PGDMP     #    (                {            Hospital    15.3    15.3                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16396    Hospital    DATABASE     ~   CREATE DATABASE "Hospital" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Turkish_Turkey.1254';
    DROP DATABASE "Hospital";
                postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
                pg_database_owner    false                       0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                   pg_database_owner    false    4            �            1255    24579 ,   addpatient(numeric, character varying, date) 	   PROCEDURE       CREATE PROCEDURE public.addpatient(IN p_id_no numeric, IN p_name_surname character varying, IN p_birth_date date)
    LANGUAGE plpgsql
    AS $$
BEGIN
    INSERT INTO patients ( id_no, name_surname, birth_date)
    VALUES ( p_id_no, p_name_surname, p_birth_date);
END;
$$;
 q   DROP PROCEDURE public.addpatient(IN p_id_no numeric, IN p_name_surname character varying, IN p_birth_date date);
       public          postgres    false    4            �            1255    24615 S   adduser(character varying, character varying, character varying, character varying) 	   PROCEDURE     E  CREATE PROCEDURE public.adduser(IN p_username character varying, IN p_password character varying, IN p_role character varying, IN p_id_number character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
    INSERT INTO users (username, password, role, id_number)
    VALUES (p_username, p_password, p_role, p_id_number);
END;
$$;
 �   DROP PROCEDURE public.adduser(IN p_username character varying, IN p_password character varying, IN p_role character varying, IN p_id_number character varying);
       public          postgres    false    4            �            1255    24590 g   addvisit(integer, timestamp without time zone, character varying, character varying, character varying) 	   PROCEDURE     �  CREATE PROCEDURE public.addvisit(IN p_patient_id integer, IN p_visit_date timestamp without time zone, IN p_doctor_name character varying, IN p_complaint character varying, IN p_form_of_treatment character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
    INSERT INTO visits (patient_id, visit_date, doctor_name, complaint, form_of_treatment)
    VALUES (p_patient_id, p_visit_date, p_doctor_name, p_complaint, p_form_of_treatment);
END;
$$;
 �   DROP PROCEDURE public.addvisit(IN p_patient_id integer, IN p_visit_date timestamp without time zone, IN p_doctor_name character varying, IN p_complaint character varying, IN p_form_of_treatment character varying);
       public          postgres    false    4            �            1255    24595    deletepatient(integer) 	   PROCEDURE     �   CREATE PROCEDURE public.deletepatient(IN p_id integer)
    LANGUAGE plpgsql
    AS $$
BEGIN
    DELETE FROM visits WHERE patient_id = p_id;
    DELETE FROM patients WHERE id = p_id;
END;
$$;
 6   DROP PROCEDURE public.deletepatient(IN p_id integer);
       public          postgres    false    4            �            1255    24591    deletevisit(integer) 	   PROCEDURE     �   CREATE PROCEDURE public.deletevisit(IN p_visit_id integer)
    LANGUAGE plpgsql
    AS $$
BEGIN
    DELETE FROM visits WHERE visit_id = p_visit_id;
END;
$$;
 :   DROP PROCEDURE public.deletevisit(IN p_visit_id integer);
       public          postgres    false    4            �            1255    24588 8   updatepatient(integer, numeric, character varying, date) 	   PROCEDURE     l  CREATE PROCEDURE public.updatepatient(IN p_id integer, IN p_id_no numeric, IN p_name_surname character varying, IN p_birth_date date)
    LANGUAGE plpgsql
    AS $$
BEGIN
    UPDATE patients
    SET id_no = p_id_no,
        name_surname = p_name_surname,
        birth_date = p_birth_date
    WHERE id = (SELECT id FROM patients WHERE id = p_id LIMIT 1);
END;
$$;
 �   DROP PROCEDURE public.updatepatient(IN p_id integer, IN p_id_no numeric, IN p_name_surname character varying, IN p_birth_date date);
       public          postgres    false    4            �            1255    24594 s   updatevisit(integer, integer, timestamp without time zone, character varying, character varying, character varying) 	   PROCEDURE       CREATE PROCEDURE public.updatevisit(IN p_visit_id integer, IN p_patient_id integer, IN p_visit_date timestamp without time zone, IN p_doctor_name character varying, IN p_complaint character varying, IN p_form_of_treatment character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
    UPDATE visits
    SET patient_id = p_patient_id,
        visit_date = p_visit_date,
        doctor_name = p_doctor_name,
        complaint = p_complaint,
        form_of_treatment = p_form_of_treatment
    WHERE visit_id = p_visit_id;
    
    
    
END;
$$;
 �   DROP PROCEDURE public.updatevisit(IN p_visit_id integer, IN p_patient_id integer, IN p_visit_date timestamp without time zone, IN p_doctor_name character varying, IN p_complaint character varying, IN p_form_of_treatment character varying);
       public          postgres    false    4            �            1259    16456    patients    TABLE     �   CREATE TABLE public.patients (
    id integer NOT NULL,
    id_no numeric(11,0) NOT NULL,
    name_surname character varying(40) NOT NULL,
    birth_date date NOT NULL
);
    DROP TABLE public.patients;
       public         heap    postgres    false    4            �            1259    16461    Hastalar_id_seq    SEQUENCE     �   ALTER TABLE public.patients ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Hastalar_id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    214    4            �            1259    16473    visits    TABLE       CREATE TABLE public.visits (
    visit_id integer NOT NULL,
    patient_id integer NOT NULL,
    visit_date timestamp without time zone NOT NULL,
    doctor_name character varying NOT NULL,
    complaint character varying NOT NULL,
    form_of_treatment character varying NOT NULL
);
    DROP TABLE public.visits;
       public         heap    postgres    false    4            �            1259    16519    Visits_visit_id_seq    SEQUENCE     �   ALTER TABLE public.visits ALTER COLUMN visit_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Visits_visit_id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    216    4            �            1259    24605    users    TABLE     �   CREATE TABLE public.users (
    username character varying NOT NULL,
    password character varying NOT NULL,
    role character varying NOT NULL,
    id_number character varying NOT NULL
);
    DROP TABLE public.users;
       public         heap    postgres    false    4                      0    16456    patients 
   TABLE DATA           G   COPY public.patients (id, id_no, name_surname, birth_date) FROM stdin;
    public          postgres    false    214   �)                 0    24605    users 
   TABLE DATA           D   COPY public.users (username, password, role, id_number) FROM stdin;
    public          postgres    false    218   Y,                 0    16473    visits 
   TABLE DATA           m   COPY public.visits (visit_id, patient_id, visit_date, doctor_name, complaint, form_of_treatment) FROM stdin;
    public          postgres    false    216   �.                  0    0    Hastalar_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public."Hastalar_id_seq"', 69, true);
          public          postgres    false    215                       0    0    Visits_visit_id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."Visits_visit_id_seq"', 165, true);
          public          postgres    false    217            v           2606    16460    patients Hastalar_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.patients
    ADD CONSTRAINT "Hastalar_pkey" PRIMARY KEY (id);
 B   ALTER TABLE ONLY public.patients DROP CONSTRAINT "Hastalar_pkey";
       public            postgres    false    214            z           2606    16479    visits Visits_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.visits
    ADD CONSTRAINT "Visits_pkey" PRIMARY KEY (visit_id);
 >   ALTER TABLE ONLY public.visits DROP CONSTRAINT "Visits_pkey";
       public            postgres    false    216            x           2606    16489    patients tc_no 
   CONSTRAINT     J   ALTER TABLE ONLY public.patients
    ADD CONSTRAINT tc_no UNIQUE (id_no);
 8   ALTER TABLE ONLY public.patients DROP CONSTRAINT tc_no;
       public            postgres    false    214            }           2606    24613    users users_pkey 
   CONSTRAINT     U   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id_number);
 :   ALTER TABLE ONLY public.users DROP CONSTRAINT users_pkey;
       public            postgres    false    218            {           1259    16487    fki_patient_visit_foreign_key    INDEX     V   CREATE INDEX fki_patient_visit_foreign_key ON public.visits USING btree (patient_id);
 1   DROP INDEX public.fki_patient_visit_foreign_key;
       public            postgres    false    216            ~           2606    16482     visits patient_visit_foreign_key    FK CONSTRAINT     �   ALTER TABLE ONLY public.visits
    ADD CONSTRAINT patient_visit_foreign_key FOREIGN KEY (patient_id) REFERENCES public.patients(id) NOT VALID;
 J   ALTER TABLE ONLY public.visits DROP CONSTRAINT patient_visit_foreign_key;
       public          postgres    false    214    216    3190               �  x�M��n!���)x*`��t��i�R)��b��6�b�4}��tm����3�9�E'�6�1��R?��w�Q�(WX24+��S �q8� ��2GÒ�Yӡհ�}�����Jc)��R�Y(��8��<�8�q_re�ۡY�е?[r��{��0��L`)�,�h����
�B.��N��`0��M��m:k��
�i4�,����Iɮ�I�4`�ҠY��:�z��|>S�[E�a>� 3g�V@o�^�bچܒ�q� �5̼*ѷ�	1z�ԧїpK�Xc-��z?��P�V���X�F��"؇'�>��
�
����*���/��e����uPV]���-N߫��JO�ɆXWzH���8��H��\c�_SU��ѓg�궬+,���V��j��1��T��1�L[�J�x^��6_7ZI0H��\�Þ|͡�����D�ɴ�_�_@l�m���`�i�I���
�o?����f�ƚ�'[�/{�c:y��S
�:�Ō�p��=YB�Yφc�]�e�S O�<�`[����_�nÔ?�2�]sc��Bb 1�5��=����s-˭�6���;�@�î'�!lϕ�k. �2� �L�x�F�|J������CY��h�����!3���) �
���?�`���j�         +  x�m��n�0��ŧ�99��$-�I74��a��*K��˞~��X]~�!��h�T�u�?
�Wʈ~<�hK#�,��Q1�Lg��8`��4)�G4$7�jJ頋&�jW"i��][#bi�����g���VX�"VF]<ap�'��g?����	�:,嚯&'"w���Fq��H�u,L�t��V'�����O�p�`c%���e诈�Y�OO{g�rn���^|�7�N�E.'0�V㖴F�R�
�`����)��Q�0�8w�D��Ω���繗�`���˥F�<�|1w�O�-|��^B�q.&0x�,�=��``�yn%0ޥ
�+���L|!��x�����z���[��J�9��ņ�(�˫��_q�2��\�x1�x��}����g�2��?`����.���%�%:m������?�0XwX�%���c)|�'loYjK�������+=x ��ri�!�ҿ�������Cܾm;�ܐ3�_XM�R>��jXdE�����%�0��fk������s"��!���܉�$��:�x�� �Ҵ~         D  x����n�6���S���W�n���-P�h�t��[�-��<3���Jv"���&�"�����=<<�Y��D
����Q�I>6�o����U�s�],�?��5�g?O�~^Ί����;�B�$��_̋��'�Y�^�j��iQ�ӗ����U��f�p�0UJ��̔���v�],�øπ\��ݥ�s��ږ�J��=�7�Ӻl��S���]6uю�[Tm����r�q$px��Q
�|��,�>�0�Rn���·��oV޿0F%�`:fT�\��[�O�쟾>P���n�;����x�1NNv;9���a��͢��Q�j.�=��g��j}�/wYn�b]V�[�6o�|��>������f,^1�����s~��]We1�"�F�o����eU����~��j�����<��!LJ�Q�(C����jz(����7麨�����Ѱ<H�h	��F[�W���h��Ǆ^4C�{ٍ�p��Y�A��5[�#��1Ju����K���6il�褎Q����2R�wÍ��Z��V����g�e��)wS���T�����i��o�����c	i��E��a�{�Ig$�Iǂ�H�kt5%��2�}�}Y4;X�� m����� ~��x�C=Oh��p0��[O�x��0��գ3��a8��QϏ�!���hˮ�Y# 麽;Z�u=k�Y�kG+zv|fl73Fj�u�a�鉍|,؄.8z��h��Z�_��үE�N7Ū�Z�1�@
�����h��k�c6����	��~0P�&&���,{C�N��np@�x��O6C?��E��Bx�mѴn���͡�޿�S~=����|>���V >�
=-K��fi<�΍�9�,�Ѐ��aT4-���[{�����K�s/�qUN��j���S���#]�����o ����l�Ӌ� 5�!���m�o��Č^���̀������*&�os ���m�0�8��x�	���,D8�6��5B}�D�������@|$Ϩ�R�9��� B��WcgjN����s�txn�2/�%�U����3I7{�e�+@�$�=�;FF@�0_��^�̸��xo	������i`�3o	W� ԝyX��E�J�>�]�3����.�PC��>���fuS��Eb�^@n
I9Rc�B�5&�K@�)�h�Y|���a)/
��|�Ca�@�q��4�C���g�����	p��1��n���=��@�3	
xQ]��x� a�z�O�`A�p��(H8@�8�X�[�H1����`�3�[I`��Tl� b�F
"�8�Ad��2�@<��%!V��	q) �5$�א,��т�^\א��\C����5/H:@��̀�2R�P"��#)fT�P�!������҉��0"���@���4�5T��Q�T���P1\C op�b��5�^\����\C����5�5�D�k�X��s Eq�j��53�kp����'[�#��B�58��Y�3���5��l#e�=�Y��X6R������5�cmX�`ӱ1�����e>�l���
�1���www�VN
�     